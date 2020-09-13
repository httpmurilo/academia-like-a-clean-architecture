using System;
using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Commands.AddCustomer
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, AddCostumerViewModel>
    {
        private readonly ICustomerRepository _repository;
        public AddCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<AddCostumerViewModel> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name,request.LastName, request.Document);

            await _repository.AddCustomer(customer);

            return new AddCostumerViewModel(customer.Id, customer.Name, customer.LastName, customer.Document);

        }
    }
}
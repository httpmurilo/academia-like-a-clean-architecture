using System;
using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Commands.UpdateCustomer
{
   
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _repository;
        public UpdateCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Customer(request.Name, request.LastName, request.Document);
            
            await _repository.UpdateCustomer(customer);
            
            return Unit.Value;
        }
    }
}
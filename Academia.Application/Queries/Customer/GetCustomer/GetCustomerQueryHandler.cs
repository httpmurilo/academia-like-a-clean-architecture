using System;
using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Queries.Customer.GetCustomer
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, GetCustomerQueryViewModel>
    {
        private readonly ICustomerRepository _repository;
        
        public GetCustomerQueryHandler(ICustomerRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public async Task<GetCustomerQueryViewModel> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetById(request.Id);
            
            var customerReturn = new GetCustomerQueryViewModel(customer.Name, customer.LastName,customer.Document, customer.Status);

            return customerReturn;        
        }
    }
}
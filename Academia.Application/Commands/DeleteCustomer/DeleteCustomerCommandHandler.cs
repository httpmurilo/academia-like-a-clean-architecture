using System;
using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Commands.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand, Unit>
    {
        private readonly ICustomerRepository _repository;
        
        public DeleteCustomerCommandHandler(ICustomerRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        public Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            _repository.RemoveCustomer(request.Id);

            return Task.FromResult(Unit.Value);
        }
    }
}
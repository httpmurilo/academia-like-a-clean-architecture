using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Commands.Employee.DeleteEmployee
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IEmployeeRepository _repository;
        public Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            _repository.RemoveEmployee(request.Id);
            return Task.FromResult(Unit.Value);

        }
    }
}
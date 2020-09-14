using System.Threading;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;
using MediatR;

namespace Academia.Application.Commands.AddEmployee
{
    public class AddEmployeeCommandHandler : IRequestHandler<AddEmployeeCommand, AddEmployeeViewModel>
    {
        private readonly IEmployeeRepository _repository;

        public AddEmployeeCommandHandler(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public async Task<AddEmployeeViewModel> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee(request.Name, request.LastName, request.Email);

            await _repository.AddEmployee(employee);

            return new AddEmployeeViewModel(employee.Name);
        }
    }
}

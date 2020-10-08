using MediatR;

namespace Academia.Application.Commands.Employee.DeleteEmployee
{
    public class DeleteEmployeeCommand : IRequest<Unit> 
    {
        public DeleteEmployeeCommand (int id) 
        {
            this.Id = id;

        }
        public int Id { get; private set; }
    }
}
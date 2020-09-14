using MediatR;

namespace Academia.Application.Commands.AddEmployee
{
    public class AddEmployeeCommand : IRequest<AddEmployeeViewModel>
    {
        public AddEmployeeCommand(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public string Name { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
    }
}
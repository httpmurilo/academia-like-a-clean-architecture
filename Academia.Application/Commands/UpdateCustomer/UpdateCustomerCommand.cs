using MediatR;

namespace Academia.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerCommand : IRequest<Unit>
    {
        public UpdateCustomerCommand(string name, string lastName, string document)
        {
            Name = name;
            LastName = lastName;
            Document = document;

        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
    }
}
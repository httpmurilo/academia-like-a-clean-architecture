using MediatR;

namespace Academia.Application.Commands.DeleteCustomer
{
    public class DeleteCustomerCommand : IRequest<Unit>
    {
        public DeleteCustomerCommand(int id)
        {
            Id = id;

        }
        public int Id { get; private set; }
    }
}
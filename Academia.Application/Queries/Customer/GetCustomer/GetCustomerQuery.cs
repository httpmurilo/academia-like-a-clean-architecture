using MediatR;

namespace Academia.Application.Queries.Customer.GetCustomer
{
    public class GetCustomerQuery : IRequest<GetCustomerQueryViewModel>
    {
        public GetCustomerQuery(int id)
        {
            Id = id;

        }
        public int Id { get; set; }
    }
}
using Academia.Core.Enums;

namespace Academia.Application.Queries.Customer.GetCustomer
{
    public class GetCustomerQueryViewModel
    {
        public GetCustomerQueryViewModel(string name, string lastName, string document, EGenericStatus status)
        {
            Name = name;
            LastName = lastName;
            Document = document;

        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public EGenericStatus Status { get; private set; }
    }
}
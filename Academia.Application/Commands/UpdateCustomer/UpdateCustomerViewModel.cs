namespace Academia.Application.Commands.UpdateCustomer
{
    public class UpdateCustomerViewModel
    {
        public UpdateCustomerViewModel(string name, string lastName, string document)
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
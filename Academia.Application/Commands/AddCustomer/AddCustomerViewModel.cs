using System;

namespace Academia.Application.Commands.AddCustomer
{
    public class AddCustomerViewModel
    {
        public AddCustomerViewModel(int id, string name, string lastName, string document)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Document = document;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
    }
}
using System;
using Academia.Core.Enums;
using MediatR;

namespace Academia.Application.Commands.AddCustomer
{
    public class AddCustomerCommand : IRequest<AddCostumerViewModel>
    {
        public AddCustomerCommand(string name, string lastName, string document)
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
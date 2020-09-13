using System;
using Academia.Core.Enums;

namespace Academia.Core.Entities
{
    public class Customer
    {
        public Customer(string name, string lastName, string document)
        {
            Name = name;
            LastName = lastName;
            Document = document;
            Status = EGenericStatus.Active;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public EGenericStatus Status { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public void MarkAsInactive()
        {
            Status = EGenericStatus.Inactive;
        }

        public void MarkAsActive()
        {
            Status = EGenericStatus.Active;
        }
    }
}
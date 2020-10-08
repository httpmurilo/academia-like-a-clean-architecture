using Academia.Core.Enums;
using Academia.Core.Shared;

namespace Academia.Core.Entities
{
    public class Employee : Entity
    {
        public Employee( string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            Status = EGenericStatus.Active;

        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public EGenericStatus Status { get; private set; }
        
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
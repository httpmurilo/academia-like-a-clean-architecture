using Academia.Core.Enums;

namespace Academia.Core.Entities
{
    public class Employee
    {
        public Employee(string name, string lastName, string email)
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
    }
}
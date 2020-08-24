using Academia.Core.Enums;

namespace Academia.Core.Entities
{
    public class Customer
    {
        public string Name { get; private set; }
        public string LastName { get; set; }
        public string Document { get; private set; }
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
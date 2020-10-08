using System;

namespace Academia.Core.Shared
{
   public abstract class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Id++;
        }

        public int Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
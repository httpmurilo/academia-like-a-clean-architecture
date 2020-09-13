
using Academia.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academia.Infra.Persistence
{
    public class PersistenceDbContext : DbContext
    {
        public PersistenceDbContext(DbContextOptions<PersistenceDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }


}
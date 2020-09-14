using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;

namespace Academia.Infra.Persistence.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly PersistenceDbContext _context;

        public EmployeeRepository(PersistenceDbContext context)
        {
            _context = context;
        }
        public async Task AddEmployee(Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
    }
}
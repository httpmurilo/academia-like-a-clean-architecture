using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;
using Microsoft.EntityFrameworkCore;

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
            if(employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            await _context.Employees.AddAsync(employee);
            await _context.SaveChangesAsync();
        }
        public async Task RemoveEmployee(int id)
        {
            var singleDelete = _context.Employees.FirstOrDefault(x => x.Id == id);
            _context.Employees.Attach(singleDelete);
            _context.Employees.Remove(singleDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> EmployeeExists(int id)
        {
            return await _context.Employees.AnyAsync(x => x.Id == id);
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }
        
        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
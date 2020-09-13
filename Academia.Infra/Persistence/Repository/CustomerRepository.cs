using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;
using Microsoft.EntityFrameworkCore;

namespace Academia.Infra.Persistence.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public readonly PersistenceDbContext _context;
        
        public CustomerRepository(PersistenceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveCustomer(int id)
        {
            var singleDelete = _context.Customers.FirstOrDefault(x => x.Id == id);
            _context.Customers.Attach(singleDelete);
            _context.Customers.Remove(singleDelete);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<bool> CustomerExists(int id)
        {
            return await _context.Customers.AnyAsync(x => x.Id == id);
        }
    }
}
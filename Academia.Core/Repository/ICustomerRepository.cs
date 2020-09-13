using System.Collections.Generic;
using System.Threading.Tasks;
using Academia.Core.Entities;

namespace Academia.Core.Repository
{
    public interface ICustomerRepository
    {
        Task AddCustomer(Customer customer);
        Task RemoveCustomer(int id);
        Task UpdateCustomer(Customer customer);
        Task<Customer> GetById(int id);
        Task<List<Customer>> GetAllCustomer();
        Task<bool> CustomerExists(int id);
    }
}
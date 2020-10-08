using System.Collections.Generic;
using System.Threading.Tasks;
using Academia.Core.Entities;

namespace Academia.Core.Repository
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(Employee employee);
        Task RemoveEmployee(int id);
        Task UpdateEmployee(Employee employee);
        Task<Employee> GetById(int id);
        Task<List<Employee>> GetAllEmployees();
        Task<bool> EmployeeExists(int id);
    }
}
using System.Threading.Tasks;
using Academia.Core.Entities;

namespace Academia.Core.Repository
{
    public interface IEmployeeRepository
    {
        Task AddEmployee(Employee employee);
    }
}
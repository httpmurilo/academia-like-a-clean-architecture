using System.Collections.Generic;
using System.Threading.Tasks;
using Academia.Core.Entities;

namespace Academia.Core.Repository
{
    public interface IPlansRepository
    {
        Task AddPlans(Plans plans);
        Task RemovePlans(int id);
        Task UpdatePlans(Plans plans);
        Task<Plans> GetById(int id);
        Task<List<Plans>> GetAllPlans();
        Task<bool> PlansExist(int id);
    }
}
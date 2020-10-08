using System.Collections.Generic;
using System.Threading.Tasks;
using Academia.Core.Entities;
using Academia.Core.Repository;

namespace Academia.Infra.Persistence.Repository
{
    public class PlansRepository : IPlansRepository
    {
        public Task AddPlans(Plans plans)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Plans>> GetAllPlans()
        {
            throw new System.NotImplementedException();
        }

        public Task<Plans> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> PlansExist(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task RemovePlans(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdatePlans(Plans plans)
        {
            throw new System.NotImplementedException();
        }
    }
}
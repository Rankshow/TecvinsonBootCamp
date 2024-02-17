using Microsoft.EntityFrameworkCore;
using TecvinsonBootCamp.Core.Entities;
using TecvinsonBootCamp.Core.Interfaces;
using TecvinsonBootCamp.Respositories.Data;

namespace TecvinsonBootCamp.Respositories.Implementation
{
    public class CohortRepositories : ICohortRepositories
    {
        private readonly TecvinsonDbContext _tecvinsonDbContext;
        public CohortRepositories(TecvinsonDbContext tecvinsonDbContext)
        {
            _tecvinsonDbContext = tecvinsonDbContext;
        }
        public async Task<Cohort> Create(Cohort cohort)
        {
            _tecvinsonDbContext.Cohorts.Add(cohort);
            _tecvinsonDbContext.SaveChanges();
            return await Task.FromResult(cohort);
        }

        public async Task<List<Cohort>> GetAll()
        {
             return await Task.FromResult(_tecvinsonDbContext
                 .Cohorts
                 .ToList());
        }
        public async Task<bool> Delete(int cohortId)
        {
            var toDelete = await _tecvinsonDbContext
                .Cohorts
                .Where(x => x.Id == cohortId).FirstOrDefaultAsync();

            if(toDelete != null)
            { 
                _tecvinsonDbContext.Cohorts.Remove(toDelete);
                _tecvinsonDbContext.SaveChanges();  
            }
            return true;
            
        }
        public async Task<Cohort> GetById(int cohortId)
        {
            var getId = await _tecvinsonDbContext
                .Cohorts.Where(x => x.Id == cohortId).FirstOrDefaultAsync();
            return getId ?? new Cohort();
        }

        public async Task<Cohort> Update(Cohort cohort)
        {
            var updateCohort = _tecvinsonDbContext.Cohorts.Update(cohort);
            _tecvinsonDbContext.SaveChanges();
            return await Task.FromResult(cohort);

        }
    }
}

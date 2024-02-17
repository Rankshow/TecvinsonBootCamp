using TecvinsonBootCamp.Core.Entities;

namespace TecvinsonBootCamp.Core.Interfaces
{
    public interface ICohortRepositories
    {
        Task<List<Cohort>> GetAll();
        Task<Cohort> Create(Cohort cohort);
        Task<bool> Delete(int cohortId);
        Task<Cohort> GetById(int cohortId);
        Task<Cohort> Update(Cohort cohort);
    }
}

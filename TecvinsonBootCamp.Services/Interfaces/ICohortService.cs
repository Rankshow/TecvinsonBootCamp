using TecvinsonBootCamp.Core.Entities;
using TecvinsonBootCamp.Services.Contract;

namespace TecvinsonBootCamp.Services.Interfaces
{
    public interface ICohortService
    {
        CohortRsp<CohortDto> Create( CohortCreateReq req);
        Task<CohortRsp<CohortDto>> Update(CohortUpdateReq req);
        Task<CohortRsp<CohortDto>> GetById(int cohortId);
        Task<CohortRsp<bool>> Delete(int cohortId);
        Task<CohortRsp<List<CohortDto>>> GetAll();
    }
}

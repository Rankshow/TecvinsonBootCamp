using TecvinsonBootCamp.Core.Interfaces;
using TecvinsonBootCamp.Services.Contract;
using TecvinsonBootCamp.Services.Extension;
using TecvinsonBootCamp.Services.Interfaces;

namespace TecvinsonBootCamp.Services.Implementation
{
    public class CohortService : ICohortService
    {
        private readonly ICohortRepositories _cohortRepositories;
        public CohortService(ICohortRepositories cohortRepositories)
        {
            _cohortRepositories = cohortRepositories;    
        }
        public CohortRsp<CohortDto> Create(CohortCreateReq req)
        {
            var createCohort = req.AsEntity();
            _cohortRepositories.Create(createCohort);

            return new CohortRsp<CohortDto>
            {
                Code = "200",
                Message = "Ok"
            };
        }

        public async Task<CohortRsp<List<CohortDto>>> GetAll()
        {
            var allCohort = await _cohortRepositories.GetAll();

            return new CohortRsp<List<CohortDto>>
            {
                Code = "200",
                Message = "Ok",
                Result = allCohort.AsDto()
            };
        }
        public async Task<CohortRsp<bool>> Delete(int cohortId)
        {
            var todelete = await _cohortRepositories.Delete(cohortId);

            return new CohortRsp<bool>
            {
                Code = "200",
                Message = "Ok",
                Result = todelete
            };
        }


        public async Task<CohortRsp<CohortDto>> GetById(int cohortId)
        {
            var getId = await _cohortRepositories.GetById(cohortId);

            if(getId == null) 
            {
                return new CohortRsp<CohortDto>
                {
                    Code = "404",
                    Message = "BadRequest result not Found"
                };
            }

            return new CohortRsp<CohortDto>
            {
                Code = "200",
                Message = "Ok",
                Result = getId.AsDto()
            };
        }

        public async Task<CohortRsp<CohortDto>> Update(CohortUpdateReq req)
        {
            var update = req.AsEntity();
            await _cohortRepositories.Update(update);

            return new CohortRsp<CohortDto>
            {
                Code = "200",
                Message = "Successfull"
            };
        }
    }
}

using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TecvinsonBootCamp.Services.Contract;
using TecvinsonBootCamp.Services.Interfaces;

namespace TecvinsonBootCamp.Presentatio.Controllers
{
    [Route("api/cohorts")]
    [ApiController]
    public class CohortController : ControllerBase
    {
        private readonly ICohortService _cohortService;
        private readonly IValidator<CohortCreateReq> _validation;
        public CohortController(ICohortService cohortService, IValidator<CohortCreateReq> validator)
        {
            _cohortService = cohortService;
            _validation = validator;
        }

        [HttpPost("add")]
        public ActionResult<BaseResponse> Create([FromBody] CohortCreateReq req)
        {
            var validateResult = _validation.Validate(req);
            if (validateResult == null) 
            {
                return BadRequest(validateResult);
            }
            
            return _cohortService.Create(req);
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse>> GetAll()
        {
            return await _cohortService.GetAll();
        }

        [HttpDelete]
        [Route("{cohortId}")]
        public async Task<ActionResult<BaseResponse>> Delete(int cohortId)
        {
            return await _cohortService.Delete(cohortId);
        }

        [HttpGet]
        [Route("{cohortId}")]
        public async Task<ActionResult<BaseResponse>> GetById(int cohortId)
        {
            return await _cohortService.GetById(cohortId);
        }

        [HttpPut]
        public async Task<ActionResult<BaseResponse>> Update(CohortUpdateReq req)
        {
            return await _cohortService.Update(req);
        }

    }
}

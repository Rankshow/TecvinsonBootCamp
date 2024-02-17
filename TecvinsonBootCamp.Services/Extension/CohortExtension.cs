using TecvinsonBootCamp.Core.Entities;
using TecvinsonBootCamp.Services.Contract;

namespace TecvinsonBootCamp.Services.Extension
{
    public static class CohortExtension
    {
        public static Cohort AsEntity(this CohortCreateReq req) 
        {
            return new Cohort
            {
                Name = req.Name,
                Year = req.Year,
                StartDate = req.StartDate,
                EndDate = req.EndDate,
                Status = req.Status,
                CreatedBy = "Micheal",
                DateCreated = DateTime.UtcNow,
                ModifiedBy = "Admin",
                DateModified = DateTime.UtcNow,    
            };
        }
        public static CohortDto AsDto(this Cohort dto) 
        {
            return new CohortDto
            {
                Id = dto.Id,
                Name = dto.Name,
                Year = dto.Year,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                Status = dto.Status
            };
        }
        public static List<CohortDto> AsDto(this List<Cohort> entities)
        {
            var cohortDtos = new List<CohortDto>();

            foreach (var entity in entities) 
            {
               cohortDtos.Add(entity.AsDto());
            }
            return cohortDtos;
        }

        public static Cohort AsEntity(this CohortUpdateReq entity)
        {
            return new Cohort
            {
                Id = entity.Id,
                Name = entity.Name,
                Year = entity.Year,
                StartDate = entity.StartDate,
                EndDate = entity.EndDate,
                Status = entity.Status,
                CreatedBy = "Micheal",
                DateCreated = DateTime.UtcNow,
                ModifiedBy = "Admin",
                DateModified = DateTime.UtcNow,
            };
        }
    }
}

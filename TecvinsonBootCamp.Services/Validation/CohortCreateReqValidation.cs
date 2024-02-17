using FluentValidation;
using TecvinsonBootCamp.Services.Contract;

namespace TecvinsonBootCamp.Services.Validation
{
    public class CohortCreateReqValidation : AbstractValidator<CohortCreateReq>
    {
        public CohortCreateReqValidation() 
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .MinimumLength(100)
                .WithMessage("Kindly provide your name");

            RuleFor(p => p.Year)
                .NotEmpty()
                .WithMessage("Year is required");

            RuleFor(p => p.StartDate)
                .NotEmpty()
                .NotNull()
                .WithMessage("StartDate is required");

            RuleFor(p => p.EndDate)
                .NotEmpty()
                .NotNull()
                .WithMessage("End date is required");

            RuleFor(p => p.Status)
                .NotEmpty()
                .WithMessage("Status is required");
        }   
    }
}

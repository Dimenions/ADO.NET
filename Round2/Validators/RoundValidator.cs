using FluentValidation;

namespace Round2.Validators
{
    public class RoundValidator : AbstractValidator<Round>
    {
        public RoundValidator()
        {
            RuleFor(p => p.x).GreaterThanOrEqualTo(0).WithMessage("Ошибка, х меньше нуля!");
            RuleFor(p => p.y).GreaterThanOrEqualTo(0).WithMessage("Ошибка, y меньше нуля!");
            RuleFor(p => p.Radius).GreaterThanOrEqualTo(0).WithMessage("Ошибка, радиус меньше нуля!");
        }   
    }
}

using CalculaJurosService.Model.DTOs;
using FluentValidation;

namespace CalculaJurosService.Validators
{
    public class CalculoValuesDtoValidator : AbstractValidator<CalculoValuesDto>
    {
        public CalculoValuesDtoValidator()
        {
            RuleFor(c => c.Periodo).NotNull();
            RuleFor(c => c.ValorInicial).NotNull();
            RuleFor(c => c.Periodo).NotNull().GreaterThan(0);
            RuleFor(c => c.ValorInicial).NotNull().GreaterThan(0).LessThan(10000);

        }
    }
}




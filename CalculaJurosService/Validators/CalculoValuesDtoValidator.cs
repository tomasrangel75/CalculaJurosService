using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculaJurosService.Model.DTOs;
using FluentValidation;

namespace CalculaJurosService.Validators
{
    public class CalculoValuesDtoValidator : AbstractValidator<CalculoValuesDto>
    {
        public CalculoValuesDtoValidator()
        {
            RuleFor(c => c.Periodo).NotNull()
                .OnAnyFailure(q => { throw new ArgumentNullException(); });
         
            RuleFor(c => c.ValorInicial).NotNull()
                .OnAnyFailure(q => { throw new ArgumentNullException(); });
         
        }
    }
}




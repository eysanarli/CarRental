using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(clr => clr.ColorName).MinimumLength(4).WithMessage("Renk adı en az 4 karakter uzunluğunda olmalıdır.");
        }
    }
}

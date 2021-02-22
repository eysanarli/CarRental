using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
           
            RuleFor(br => br.BrandName).MinimumLength(2).WithMessage("Marka adı en az 2 karakter uzunluğunda olmalıdır.");
        }
    }
}

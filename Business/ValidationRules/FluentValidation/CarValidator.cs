using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(cr => cr.DailyPrice).NotEmpty();
            RuleFor(cr => cr.DailyPrice).GreaterThan(0).WithMessage("Aracın günlük fiyatı 0'dan büyük olmalıdır.");
            RuleFor(cr => cr.ModelYear).GreaterThan(0).WithMessage("Aracın model yılı 0'dan büyük olmalıdır.");
            RuleFor(cr => cr.Descriptions).MinimumLength(5).WithMessage("Araç açıklaması en az 5 karakter uzunluğunda olmalıdır.");

        }
    }
}

using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(usr => usr.FirstName).MinimumLength(2);
            RuleFor(usr => usr.LastName).MinimumLength(2);
            RuleFor(usr => usr.Password).NotEmpty();
            RuleFor(usr => usr.Email).NotEmpty();
            RuleFor(usr => usr.Password).MaximumLength(15);

        }
    }
}

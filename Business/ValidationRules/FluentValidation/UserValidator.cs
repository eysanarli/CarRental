using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        IUserDal _userDal = new EfUserDal();
        public UserValidator()
        {
            RuleFor(usr => usr.FirstName).MinimumLength(2);
            RuleFor(usr => usr.LastName).MinimumLength(2);
            RuleFor(usr => usr.Password).NotEmpty();
            RuleFor(usr => usr.Email).NotEmpty();
            RuleFor(usr => usr.Password).MaximumLength(15);
            RuleFor(u => u.Email).Must(checkOtherEmail).WithMessage(Messages.UserEmailExist);

        }

        private bool checkOtherEmail(string arg)
        {
            var otherUsers = _userDal.GetAll();
            var emails = otherUsers.Find(e => e.Email == arg);
            return emails.Email.Equals(null);
        }
    }
}

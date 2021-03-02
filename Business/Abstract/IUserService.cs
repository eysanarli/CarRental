using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<User> GetById(int id);
        IResult Update(User user);

        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}

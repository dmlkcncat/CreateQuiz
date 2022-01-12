using Business.Abstract;
using Business.Constans;
using Core.Ultities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        IResult IUserService.Add(User user)
        {
            if (user.UserName.Length < 5)
            {
                return new ErrorResult(Messages.UserNotAdded);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }
    }
}

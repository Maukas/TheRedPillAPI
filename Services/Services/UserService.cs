using DataAccess.Context;
using DataAccess.UnitOfWorksInterfaces;
using Entities;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork<UserAPIContext> _uow { get; set; }
        public UserService(IUnitOfWork<UserAPIContext> unitOfWork)
        {
            _uow = unitOfWork;
        }

        public User GetOne()
        {
            return _uow.GetRepository<User>().GetFirstOrDefault(u => u.GAccountId == "1");
        }
        public void CreateOne(string gAccountMail)
        {
            User _user = new User();
             _user.GAccountId = "1";
            _user.GAccountMail = gAccountMail;
             _uow.GetRepository<User>().Add(_user);
            try
            {
                _uow.Save();
            }
            catch (Exception ex)
            {
            }
        }
    }
}

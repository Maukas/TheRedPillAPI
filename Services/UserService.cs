using DataAccess.Context;
using DataAccess.UnitOfWorksInterfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class UserService     
    {
        private IUnitOfWork<UserAPIContext> _uow;
        public UserService(IUnitOfWork<UserAPIContext> unitOfWork)
        {
            _uow = unitOfWork;
        }

        public User GetOne()
        {
            return _uow.GetRepository<User>().GetFirstOrDefault(u => u.GAccountId == "1");
        }
    }
}

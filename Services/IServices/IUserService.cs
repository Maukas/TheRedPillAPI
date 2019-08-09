using DataAccess.Context;
using DataAccess.UnitOfWorksInterfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.IServices
{
    public interface IUserService
    {
        User GetOne();
        void CreateOne(string gAccountMail);
    }
}

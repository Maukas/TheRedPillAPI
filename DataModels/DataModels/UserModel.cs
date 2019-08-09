using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.DataModels
{
    public class UserModel
    {
        public UserModel(string gAccountMail)
        {
            GAccountMail = gAccountMail;
        }
        public string GAccountMail;
    }
}

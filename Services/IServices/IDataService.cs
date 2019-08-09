using DataModels.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.IServices
{
   public interface IDataService
    {
         void AddAnonymousSessionData(AnonymousSessionDataModel sessionData);
         void AddUserSessionData();

    }
}

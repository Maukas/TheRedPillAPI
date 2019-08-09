using DataAccess.Context;
using DataAccess.UnitOfWorksInterfaces;
using DataModels.DataModels;
using Entities;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    class DataService : IDataService 
    {
        private IUnitOfWork<DataAPIContext> _uow;
        public DataService(IUnitOfWork<DataAPIContext> unitOfWork)
        {
            if(unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _uow = unitOfWork;
        }

        public void AddAnonymousSessionData(AnonymousSessionDataModel sessionData)
        {
            List<Data> dataToInsert = new List<Data>();
            foreach (var key in sessionData._data.Keys)
            {
                sessionData._data[key].ForEach(d =>
                {
                    dataToInsert.Add(
                        new Data(d, sessionData._recordInformations[key], key)
                    );
                });


                _uow.GetRepository<Data>().Add((IEnumerable<Data>)dataToInsert);
            }
        }
        public void AddUserSessionData()
        {

        }
    }
}

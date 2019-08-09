using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.DataModels
{
    public class AnonymousSessionDataModel
    {
        public Dictionary<int, List<string>> _data { get; set; }
        public Dictionary<int,string> _recordInformations { get; set; }

        public AnonymousSessionDataModel(Dictionary<int,List<string>> data, Dictionary<int,string> _informations)
        {
            _data = data ?? throw new ArgumentNullException(nameof(data));
            _recordInformations = _informations ?? throw new ArgumentNullException(nameof(_informations));
        }

    }
}

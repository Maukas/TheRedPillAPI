using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Data : Entity
    {
        public Data() { }
        public Data(string dataJson,string recordName, int? recordNumber)
        {
            DataJson = dataJson ?? throw new ArgumentNullException(nameof(dataJson));
            RecordName = recordName ?? throw new ArgumentNullException(nameof(recordName));
            RecordNumber = recordNumber ?? throw new ArgumentNullException(nameof(recordNumber));
        }
        public Guid DataId { get; set; }
        public string DataJson { get; set; }
        public string RecordName { get; set; }
        public int RecordNumber { get; set; }
        public Guid UserAccountId { get; set; }


    }
}

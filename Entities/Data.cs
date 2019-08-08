using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Data : Entity
    {
        public Guid DataId { get; set; }
        public string DataJson { get; set; }
        public Guid UserAccountId { get; set; }


    }
}

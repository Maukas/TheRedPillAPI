using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class User
    {
        public Guid UserId { get; set; }
        public string GAccountId { get; set; }
        public string GAccountMail { get; set; }
        public bool ShareData { get; set; }


    }
}

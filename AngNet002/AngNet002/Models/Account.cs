using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngNet002.Models
{
    public class Account
    {
        public string accountId { get; set; }
        public string accountName { get; set; }
        public int type { get; set; }
        public string accountGroupId { get; set; }
        public DateTime createTimeStamp { get; set; }
        public DateTime updateTimeStamp { get; set; }
    }
}

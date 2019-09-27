using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngNet002.Models
{
    public class AccountGroup
    {
        public string accountGroupId { get; set; }
        public string groupName { get; set; }
        public DateTime createTimeStamp { get; set; }
        public DateTime updateTimeStamp { get; set; }
    }
}

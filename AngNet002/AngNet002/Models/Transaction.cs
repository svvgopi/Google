using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngNet002.Models
{
    public class Transaction
    {
        public string transactionId { get; set; }
        public string fromAccountId { get; set; }
        public string toAccountId { get; set; }
        public double amount { get; set; }

    }
}

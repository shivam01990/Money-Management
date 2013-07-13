using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisaabManagement.Entities
{
    class UserBalanceEntity
    {
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public string AmountType { get; set; }
        public string Remarks { get; set; }
    }
}

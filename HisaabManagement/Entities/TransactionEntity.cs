using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisaabManagement.Entities
{
    class TransactionEntity
    {
       public string FromTransaction { get; set; }
       public string ToTransaction { get; set; }
       public string transactionType { get; set; }
       public decimal CreditAmount { get; set; }
       public decimal DebitAmount { get; set; }
       public string Remarks { get; set; }
       public Nullable<DateTime> TransactionDate { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisaabManagement.Entities;

namespace HisaabManagement.Datalayer
{
    class TransactionProvider
    {
        public static List<TransactionEntity> GetGridData(DateTime fromdate,DateTime Todate)
        {
            List<TransactionEntity> lst = null;
            using (managementEntities db = new managementEntities())
            {
                var derived_1 = from u in db.tblmembermasters select u;
                lst = (from u in db.tblmembermasters
                       join t in db.tbltransactionmasters on u.id equals t.transactionfrom
                       join ts in db.tbltransactiontypes on t.transactiontype equals ts.id
                       join d in derived_1 on t.transactionto equals d.id
                       where t.transactiondate >= fromdate && t.transactiondate <= Todate
                       orderby t.id descending
                       select new TransactionEntity
                       {
                           FromTransaction = u.username,
                           ToTransaction = d.username,
                           transactionType = ts.Type,
                           CreditAmount = t.credit,
                           DebitAmount = t.debit,
                           Remarks = t.remarks,
                           TransactionDate = t.transactiondate
                       }).ToList();


            }
            return lst;
        }
    }
}

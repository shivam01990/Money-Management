using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisaabManagement.Entities;

namespace HisaabManagement.Datalayer
{
    class UserProvider
    {
        public static decimal GetUserBalance(Int64 userid)
        {
            decimal totoalamount = 0;
            List<decimal> amount;
            using (managementEntities db = new managementEntities())
            {
                amount =( from u in db.tbltransactionmasters where u.transactionto == userid select ( u.credit - u.debit)).ToList();
            }
            totoalamount = amount.ToArray().Sum();
            return totoalamount ;
        }

        public static List<tblmembermaster> GetAllUser()
        {
            List<tblmembermaster> lst = null;
            using (managementEntities db = new managementEntities())
            {
                lst = (from u in db.tblmembermasters 
                       select u).ToList();
            }

            return lst;
        }

        public static decimal Get_balance_bw_Users(Int64 fromuserid, Int64 touserid)
        {
            decimal totoalamount = 0;
            
            List<decimal> amount;
            List<decimal> reverseamount;
           
                using (managementEntities db = new managementEntities())
                {
                    amount = (from u in db.tbltransactionmasters where (u.transactionto == fromuserid && u.transactionfrom == touserid) select (u.credit - u.debit)).ToList();
                    reverseamount = (from u in db.tbltransactionmasters where (u.transactionto == touserid && u.transactionfrom == fromuserid) select (u.credit - u.debit)).ToList();

                }
            
            totoalamount = amount.ToArray().Sum()-reverseamount.ToArray().Sum();
 
            return totoalamount;
        }
    }
}

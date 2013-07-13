using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisaabManagement.Entities;
using HisaabManagement.Datalayer;


namespace HisaabManagement.Helper
{
    class Helper
    {
        public static bool ISConnectedToInternet()
        {
         return   System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
        }
        public static List<UserBalanceEntity> users_balancegrid_data { get; set; }

        public static void check_All_usersbalance_grid_data()
        {
            List<tblmembermaster> lstmember = UserProvider.GetAllUser();
            List<UserBalanceEntity> lstdata = new List<UserBalanceEntity>();
            foreach (tblmembermaster member in lstmember)
            {
                UserBalanceEntity temp = new UserBalanceEntity();
                decimal balance = UserProvider.GetUserBalance(member.id);
                temp.Username = member.username;
                if (balance != 0)
                {
                    temp.Amount = balance > 0 ? balance : balance * (-1);
                    temp.Remarks = balance > 0 ? " Amount " + temp.Amount + " pay to Other Users " : " Amount " + temp.Amount + " pay by Other Users ";
                    temp.AmountType = balance > 0 ? " Less Balance " : " Over Balance  ";
                }
                else
                {
                    temp.Amount = balance;
                    temp.Remarks = "Balanced";
                    temp.AmountType = "Balanced";
                }
                lstdata.Add(temp);
            }
            Helper.users_balancegrid_data = lstdata;
        }
        public static List<UserBalanceEntity> user_balance_grid_data(Int64 Userid )
        {
            List<tblmembermaster> lstmember = UserProvider.GetAllUser();
            List<UserBalanceEntity> lstdata = new List<UserBalanceEntity>();
            foreach (tblmembermaster member in lstmember)
            {
                if (member.id != Userid)
                {
                    UserBalanceEntity temp = new UserBalanceEntity();
                    decimal balance = UserProvider.Get_balance_bw_Users(member.id, Userid);
                    temp.Username = member.username;
                    if (balance != 0)
                    {
                        temp.Amount = balance > 0 ? balance : balance * (-1);
                        temp.Remarks = balance > 0 ? temp.Username + " will pay Amount " + temp.Amount : " You will pay Amount " + temp.Amount + " to " + temp.Username;
                        temp.AmountType = balance > 0 ? "-NA-" : "-NA-";
                    }
                    else
                    {
                        temp.Amount = balance;
                        temp.Remarks = "Balanced";
                        temp.AmountType = "Balanced";
                    }
                    lstdata.Add(temp);
                }
            }
            return lstdata;
        }
    }
}

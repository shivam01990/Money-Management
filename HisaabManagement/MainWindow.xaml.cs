using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HisaabManagement.Datalayer;

namespace HisaabManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (!Helper.Helper.ISConnectedToInternet())
            {
                MessageBox.Show(" You are not Connected to Internet ");
                this.Close();
                return;
            }
            checklastTxn();
            Dropdownbindtxnfrom();
            Listboxbind();
           
        }

        protected void checklastTxn()
        {
            try
            {
                using (managementEntities db = new managementEntities())
                {
                    var res = (from t in db.tbltransactionmasters
                               join u in db.tblmembermasters on t.transactionfrom equals u.id where t.credit==0
                               orderby t.id descending
                               select new { t.remarks, u.username }).FirstOrDefault();
                    if (res != null)
                    {
                        lsttransactionfrom.Content = res.username;
                        lsttransactionfrom_remarks.Content = res.remarks;
                    }
                    else
                    {
                        lsttransactionfrom.Content = "NA";
                        lsttransactionfrom_remarks.Content = "NA";
                    }

                }
            }
            catch
            { }

        }

        protected void Dropdownbindtxnfrom()
        {
            using (managementEntities db = new managementEntities())
            {
                combofromtransaction.Items.Clear();
                var drp = (from u in db.tblmembermasters select new { u.id, u.username }).ToList();
                try
                {
                    if (drp != null)
                    {
                        combofromtransaction.ItemsSource = drp;
                        combofromtransaction.DisplayMemberPath = "username";
                        combofromtransaction.SelectedValuePath = "id";
                    }
                }
                catch
                { }


            }

        }

        protected void Listboxbind()
        {
            using (managementEntities db = new managementEntities())
            {
                listboxtotxn.Items.Clear();
                var drp = (from u in db.tblmembermasters select new { u.id, u.username }).ToList();
                try
                {
                    if (drp != null)
                    {
                        listboxtotxn.ItemsSource = drp;
                        listboxtotxn.DisplayMemberPath = "username";
                        listboxtotxn.SelectedValuePath = "id";
                      
                    }
                }
                catch
                { }


            }

        }

        private void btnsubmit_Click(object sender, RoutedEventArgs e)
        {
            progressbar.Value = 10;
            string fromuseridstr =null;
            try
            {
                 fromuseridstr = combofromtransaction.SelectedValue.ToString();
            }
            catch
            { }
            if ((fromuseridstr == null) || (fromuseridstr == "-1"))
            {
                MessageBox.Show("Select from Transaction");
                progressbar.Value = 0;
                return;
            }
                Int64 fromuserid = int.Parse(fromuseridstr);
                decimal amount = 0;
                decimal count = 0;
                decimal distributedamount = 0;
                if (txtamount.Text.Trim() == "")
                {
                    MessageBox.Show("Amount is Empty");
                    progressbar.Value = 0;
                    return; 
                }
                decimal.TryParse(txtamount.Text,out amount);
                decimal.TryParse(listboxtotxn.SelectedItems.Count.ToString(), out count);
                if (count == 0)
                {
                    MessageBox.Show("Distribute Transaction is not Selected");
                    progressbar.Value = 0;
                    return;
                }
                try { distributedamount = amount / count; }
                catch { }
                progressbar.Value = 30;
               try{
                   List<Int64> lstid = new List<Int64>();
                   using (managementEntities db = new managementEntities())
                   {
                       tbltransactionmaster tmdebit = new tbltransactionmaster();
                       tmdebit.transactionfrom = fromuserid;
                       tmdebit.transactionto = fromuserid;
                       tmdebit.transactiontype = 2;
                       tmdebit.remarks = txtremarks.Text;
                       tmdebit.transactiondate = DateTime.Now;
                       tmdebit.credit = 0;
                       tmdebit.debit = amount;
                       db.tbltransactionmasters.Add(tmdebit);
                       progressbar.Value = 50;
                       foreach (dynamic item in listboxtotxn.SelectedItems)
                       {
                           tbltransactionmaster tm = new tbltransactionmaster();
                           tm.transactionfrom = fromuserid;
                           tm.transactionto = item.id;
                           tm.transactiontype = 1;
                           tm.remarks = txtremarks.Text;
                           tm.transactiondate = DateTime.Now;
                           tm.credit = distributedamount;
                           tm.debit = 0;
                           // MessageBox.Show((item.id).ToString());
                           db.tbltransactionmasters.Add(tm);
                           lstid.Add(item.id);
                       }
                       progressbar.Value = 80;
                       //if (!lstid.Contains(fromuserid))
                       //{
                       //    progressbar.Value = 0;
                       //    MessageBox.Show("Select From Transaction Member in Distribute Transaction");
                       //    return;
                       //}
                       db.SaveChanges();
                       progressbar.Value = 100;
                       MessageBox.Show("Transaction Completed");
                       progressbar.Value = 0;
                      // Helper.Helper.check_All_usersbalance_grid_data();
                   }


               }
               catch
               { 
                   MessageBox.Show("Transaction fails");
               }

               checklastTxn();
               txtremarks.Text = "";
               txtamount.Text = "";
               listboxtotxn.UnselectAll();
               combofromtransaction.SelectedValue = false;

              // Dropdownbindtxnfrom();
              //Listboxbind();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            CheckBalance ob = new CheckBalance();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
          //  this.Close();
        }

       

        private void menutotaltxn_Click(object sender, RoutedEventArgs e)
        {
            TotalTransactions ob = new TotalTransactions();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void menu_insivisualtxn_Click(object sender, RoutedEventArgs e)
        {
            IndivisualTransaction ob = new IndivisualTransaction();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        

        

       
    }
}

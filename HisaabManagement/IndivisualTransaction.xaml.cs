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
using System.Windows.Shapes;
using HisaabManagement.Datalayer;

namespace HisaabManagement
{
    /// <summary>
    /// Interaction logic for IndivisualTransaction.xaml
    /// </summary>
    public partial class IndivisualTransaction : Window
    {
        public IndivisualTransaction()
        {
            InitializeComponent();
            Dropdownbind();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow ob = new MainWindow();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void menu_insivisualtxn_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void menutotaltxn_Click(object sender, RoutedEventArgs e)
        {
            TotalTransactions ob = new TotalTransactions();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        protected void Dropdownbind()
        {
            using (managementEntities db = new managementEntities())
            {

                       combofrom.Items.Clear();
                var drp = (from u in db.tblmembermasters select new { u.id, u.username }).ToList();
                try
                {
                    if (drp != null)
                    {
                        combofrom.ItemsSource = drp;
                        combofrom.DisplayMemberPath = "username";
                        combofrom.SelectedValuePath = "id";

                        comboto.ItemsSource = drp;
                        comboto.DisplayMemberPath = "username";
                        comboto.SelectedValuePath = "id";
                    }
                }
                catch
                { }


            }

        }

        private void btntransfer_Click(object sender, RoutedEventArgs e)
        {

            progressbar.Value = 10;
            string fromuseridstr = null;
            string touseridstr = null;
            try
            {
                fromuseridstr = combofrom.SelectedValue.ToString();
            }
            catch
            { }

            try
            {
                touseridstr = comboto.SelectedValue.ToString();
            }
            catch { }

            if ((fromuseridstr == null) || (fromuseridstr == "-1"))
            {
                MessageBox.Show("Select from Transaction");
                progressbar.Value = 0;
                return;
            }

            if ((touseridstr == null) || (touseridstr == "-1"))
            {
                MessageBox.Show("Select to Transaction");
                progressbar.Value = 0;
                return;
            }
            Int64 fromuserid = int.Parse(fromuseridstr);
            Int64 touserid = Int64.Parse(touseridstr);
            decimal amount = 0;
        
           
            if (txtamount.Text.Trim() == "")
            {
                MessageBox.Show("Amount is Empty");
                progressbar.Value = 0;
                return;
            }
            decimal.TryParse(txtamount.Text, out amount);
          
          
            progressbar.Value = 30;
            if (fromuserid == touserid)
            {
                progressbar.Value = 0;
                MessageBox.Show("Select From Transaction Member in Distribute Transaction");
                return;
            }
            try
            {
                List<Int64> lstid = new List<Int64>();
                using (managementEntities db = new managementEntities())
                {
                    tbltransactionmaster tmdebit = new tbltransactionmaster();
                    tbltransactionmaster tmcredit = new tbltransactionmaster();
                   //debit transaction
                    tmdebit.transactionfrom = fromuserid;
                    tmdebit.transactionto = fromuserid;
                    tmdebit.transactiontype = 2;
                    tmdebit.remarks = txtremarks.Text;
                    tmdebit.transactiondate = DateTime.Now;
                    tmdebit.credit = 0;
                    tmdebit.debit = amount;
                    db.tbltransactionmasters.Add(tmdebit);
                    progressbar.Value = 50;
                    //credit transaction
                    tmcredit.transactionfrom = fromuserid;
                    tmcredit.transactionto = touserid;
                    tmcredit.transactiontype = 1;
                    tmcredit.remarks = txtremarks.Text;
                    tmcredit.transactiondate = DateTime.Now;
                    tmcredit.credit = amount;
                    tmcredit.debit = 0;
                    db.tbltransactionmasters.Add(tmcredit);
                    progressbar.Value = 80;
                    db.SaveChanges();
                    progressbar.Value = 100;
                    MessageBox.Show("Transaction Completed");
                    progressbar.Value = 0;
                    //Helper.Helper.check_All_usersbalance_grid_data();
                }


            }
            catch
            {
                MessageBox.Show("Transaction fails");
            }

            
            txtremarks.Text = "";
            txtamount.Text = "";
            combofrom.SelectedValue = false;
            comboto.SelectedValue = false;
           

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            CheckBalance ob = new CheckBalance();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }
    }
}

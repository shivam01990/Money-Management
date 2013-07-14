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
using HisaabManagement.Entities;
using HisaabManagement.Helper;

namespace HisaabManagement
{
    /// <summary>
    /// Interaction logic for CheckBalance.xaml
    /// </summary>
    public partial class CheckBalance : Window
    {
        public CheckBalance()
        {
            InitializeComponent();
            Bindgriddata();
            Dropdownbind();
        }

        protected void Bindgriddata()
        {
           
                Helper.Helper.check_All_usersbalance_grid_data();
                grduserbalance.ItemsSource = Helper.Helper.users_balancegrid_data;      
        }

        protected void Dropdownbind()
        {
            using (managementEntities db = new managementEntities())
            {
                combouser.Items.Clear();
                var drp = (from u in db.tblmembermasters select new { u.id, u.username }).ToList();
                try
                {
                    if (drp != null)
                    {
                        combouser.ItemsSource = drp;
                        combouser.DisplayMemberPath = "username";
                        combouser.SelectedValuePath = "id";
                    }
                }
                catch
                { }


            }

        }

        private void combouser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            string useridstr = null;
            Int64 touserid = 0;
            try
            {
                useridstr = combouser.SelectedValue.ToString();
                Int64.TryParse(useridstr, out touserid);
              //  MessageBox.Show(touserid.ToString());
            }
            catch
            { }
            if ((useridstr == null) || (useridstr == "-1"))
            {
                MessageBox.Show(" No User is Selected");
                return;
            }
            grduserbalance_detail.ItemsSource = Helper.Helper.user_balance_grid_data(touserid);
        }

        private void menu_distributedtxn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ob = new MainWindow();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void menu_indivisualtxn_Click(object sender, RoutedEventArgs e)
        {
            IndivisualTransaction ob = new IndivisualTransaction();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void menu_checkbalance_Click(object sender, RoutedEventArgs e)
        {
            return;
        }

        private void menu_totaltxn_Click(object sender, RoutedEventArgs e)
        {
            TotalTransactions ob = new TotalTransactions();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            // base.OnClosing(e);
            App.Current.Shutdown();
        }

    }
}

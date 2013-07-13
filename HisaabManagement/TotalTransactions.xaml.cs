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
    /// Interaction logic for TotalTransactions.xaml
    /// </summary>
    public partial class TotalTransactions : Window
    {
        public TotalTransactions()
        {
            InitializeComponent();
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
            CheckBalance ob = new CheckBalance();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void menu_totaltxn_Click(object sender, RoutedEventArgs e)
        {
            TotalTransactions ob = new TotalTransactions();
            ob.Owner = this;
            this.Hide();
            ob.ShowDialog();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            DateTime fromdate = DateTime.MinValue;
            DateTime todate = DateTime.MaxValue;

            DateTime.TryParse(dpfromdate.Text, out fromdate);
            DateTime.TryParse(dptodate.Text, out todate);
            gridtxn.ItemsSource = TransactionProvider.GetGridData(fromdate, todate);

        }
    }
}

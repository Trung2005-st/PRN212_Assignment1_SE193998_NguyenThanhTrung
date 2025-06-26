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

namespace Lucy_SalesManagement
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        public EmployeeWindow(string username)
        {
            InitializeComponent();
            txtWelcome.Text = $"Welcome, {username}! Let's begin our service.";
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            // Trở về login
            var login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            ManageCustomerWindow m= new ManageCustomerWindow();
            m.Show();
            this.Close();
        }

        private void ManageProducts_Click(object sender, RoutedEventArgs e)
        {
            ManageProductWindow m= new ManageProductWindow();
            m.Show();
            this.Close();
        }

        private void ManageOrders_Click(object sender, RoutedEventArgs e)
        {
            ManageOrderWindow m= new ManageOrderWindow();
            m.Show();
            this.Close();
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            ManageReportWindow m= new ManageReportWindow();
            m.Show();
            this.Close();
        }
    }
}

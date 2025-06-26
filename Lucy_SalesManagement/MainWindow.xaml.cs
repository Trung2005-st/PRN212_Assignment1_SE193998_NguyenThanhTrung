using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccessLayer;
using Services;

namespace Lucy_SalesManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerService customerService= new CustomerService();
        EmployeeService employeeService= new EmployeeService();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            Customer customer= new Customer();
            customer.Phone = txtCustomerPhone.Text;
            bool check = customerService.GetCustomer(customer);
            if (check)
            {
                CustomerWindow cw= new CustomerWindow();
                cw.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Your phone is not valid!");
            }
        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.UserName= txtAdminUser.Text;
            employee.Password = txtAdminPass.Password;
            bool check= employeeService.GetEmployee(employee);
            if (check)
            {
                EmployeeWindow cw = new EmployeeWindow(txtAdminUser.Text);
                cw.Show();
                this.Close();
            }else
            {
                MessageBox.Show("Your username or password is invalid!");
            }
        }
    }
}
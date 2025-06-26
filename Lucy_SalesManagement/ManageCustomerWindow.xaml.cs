using System;
using System.Windows;
using System.Windows.Controls;
using DataAccessLayer;
using Services;

namespace Lucy_SalesManagement
{
    public partial class ManageCustomerWindow : Window
    {
        private readonly CustomerService customerService = new CustomerService();
        private bool isCompleted = false;

        public ManageCustomerWindow()
        {
            InitializeComponent();
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            isCompleted = false;
            dgCustomers.ItemsSource = customerService.GetAllCustomers();
            isCompleted = true;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                var c = new DataAccessLayer.Customer
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text
                };

                bool added = customerService.SaveCustomer(c);
                if (added)
                    DisplayCustomers();
                else
                    MessageBox.Show("A customer with the same ID already exists.",
                                    "Add Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer:\n" + ex.Message,
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                isCompleted = true;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                var c = new DataAccessLayer.Customer
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    CompanyName = txtCompanyName.Text,
                    ContactName = txtContactName.Text,
                    ContactTitle = txtContactTitle.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text
                };

                bool updated = customerService.UpdateCustomer(c);
                if (updated)
                    DisplayCustomers();
                else
                    MessageBox.Show("Customer not found or update failed.",
                                    "Update Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer:\n" + ex.Message,
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                isCompleted = true;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Do you really want to delete this customer?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result != MessageBoxResult.Yes) return;

            try
            {
                isCompleted = false;
                var c = new DataAccessLayer.Customer
                {
                    CustomerID = int.Parse(txtCustomerID.Text)
                };

                bool deleted = customerService.DeleteCustomer(c);
                if (deleted)
                    DisplayCustomers();
                else
                    MessageBox.Show("Customer not found or delete failed.",
                                    "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer:\n" + ex.Message,
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                isCompleted = true;
            }
        }

        private void dgCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isCompleted || e.AddedItems.Count == 0) return;

            var c = e.AddedItems[0] as Customer;
            if (c == null) return;

            txtCustomerID.Text = c.CustomerID.ToString();
            txtCompanyName.Text = c.CompanyName;
            txtContactName.Text = c.ContactName;
            txtContactTitle.Text = c.ContactTitle;
            txtAddress.Text = c.Address;
            txtPhone.Text = c.Phone;
        }
    }
}

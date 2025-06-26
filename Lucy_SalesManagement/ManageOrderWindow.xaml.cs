using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataAccessLayer;
using Services;

namespace Lucy_SalesManagement
{
    public partial class ManageOrderWindow : Window
    {
        private readonly OrderService orderService = new OrderService();
        private readonly OrderDetailService detailService = new OrderDetailService();
        private bool isCompleted = false;

        public ManageOrderWindow()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            isCompleted = false;
            dgOrders.ItemsSource = orderService.GetAllOrders();
            dgOrderDetails.ItemsSource = null;
            isCompleted = true;
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                var o = new DataAccessLayer.Order
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    CustomerID = int.Parse(txtOrderCustomerID.Text),
                    EmployeeID = int.Parse(txtOrderEmployeeID.Text),
                    OrderDate = dpOrderDate.SelectedDate ?? DateTime.Now
                };
                bool ok = orderService.SaveOrder(o);
                if (ok) LoadOrders();
                else MessageBox.Show("OrderID already exists.", "Add Order", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating order:\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { isCompleted = true; }
        }

        private void dgOrders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isCompleted || e.AddedItems.Count == 0) return;

            var o = e.AddedItems[0] as Order;
            if (o == null) return;

            txtOrderID.Text = o.OrderID.ToString();
            txtOrderCustomerID.Text = o.CustomerID.ToString();
            txtOrderEmployeeID.Text = o.EmployeeID.ToString();
            dpOrderDate.SelectedDate = o.OrderDate;

            // Load corresponding details
            isCompleted = false;
            dgOrderDetails.ItemsSource = detailService.GetDetailsByOrder(o.OrderID);
            isCompleted = true;
        }

        private void AddDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                var od = new Order_Detail
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtDetailProductID.Text),
                    UnitPrice = decimal.Parse(txtDetailUnitPrice.Text),
                    Quantity = short.Parse(txtDetailQuantity.Text),
                    Discount = float.Parse(txtDetailDiscount.Text)
                };
                bool ok = detailService.SaveOrderDetail(od);
                if (ok)
                    dgOrderDetails.ItemsSource = detailService.GetDetailsByOrder(od.OrderID);
                else
                    MessageBox.Show("This detail already exists.", "Add Detail", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding detail:\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { isCompleted = true; }
        }

        private void UpdateDetail_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isCompleted = false;
                var od = new Order_Detail
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtDetailProductID.Text),
                    UnitPrice = decimal.Parse(txtDetailUnitPrice.Text),
                    Quantity = short.Parse(txtDetailQuantity.Text),
                    Discount = float.Parse(txtDetailDiscount.Text)
                };
                bool ok = detailService.UpdateOrderDetail(od);
                if (ok)
                    dgOrderDetails.ItemsSource = detailService.GetDetailsByOrder(od.OrderID);
                else
                    MessageBox.Show("Update failed.", "Update Detail", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating detail:\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { isCompleted = true; }
        }

        private void DeleteDetail_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Delete this detail?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question)
                != MessageBoxResult.Yes) return;

            try
            {
                isCompleted = false;
                var od = new Order_Detail
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    ProductID = int.Parse(txtDetailProductID.Text)
                };
                bool ok = detailService.DeleteOrderDetail(od);
                if (ok)
                    dgOrderDetails.ItemsSource = detailService.GetDetailsByOrder(od.OrderID);
                else
                    MessageBox.Show("Delete failed.", "Delete Detail", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting detail:\n" + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally { isCompleted = true; }
        }

        private void dgOrderDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!isCompleted || e.AddedItems.Count == 0) return;

            var od = e.AddedItems[0] as Order_Detail;
            if (od == null) return;

            txtDetailProductID.Text = od.ProductID.ToString();
            txtDetailUnitPrice.Text = od.UnitPrice.ToString();
            txtDetailQuantity.Text = od.Quantity.ToString();
            txtDetailDiscount.Text = od.Discount.ToString();
        }
    }
}

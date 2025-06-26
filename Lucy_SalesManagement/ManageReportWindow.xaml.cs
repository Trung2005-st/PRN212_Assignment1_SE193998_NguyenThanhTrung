using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Services;          // OrderService, OrderDetailService
using BusinessObject;    // Order, OrderDetail

namespace Lucy_SalesManagement
{
    public partial class ManageReportWindow : Window
    {
        private readonly OrderService orderService = new OrderService();
        private readonly OrderDetailService detailService = new OrderDetailService();

        public ManageReportWindow()
        {
            InitializeComponent();

            // Thiết lập ngày mặc định
            dpStart.SelectedDate = DateTime.Today.AddDays(-7);
            dpEnd.SelectedDate = DateTime.Today;

            // Tạo báo cáo ngay khi mở
            GenerateReport();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
            => GenerateReport();

        private void GenerateReport()
        {
            if (dpStart.SelectedDate == null || dpEnd.SelectedDate == null)
            {
                MessageBox.Show("Please select both start and end dates.",
                                "Invalid Dates", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var start = dpStart.SelectedDate.Value.Date;
            var end = dpEnd.SelectedDate.Value.Date.AddDays(1).AddTicks(-1);

            // Lấy đơn trong khoảng, tính tổng, sắp xếp giảm dần
            var data = orderService.GetAllOrders()
                .Where(o => o.OrderDate >= start && o.OrderDate <= end)
                .Select(o => new
                {
                    o.OrderID,
                    o.OrderDate,
                    o.CustomerID,
                    o.EmployeeID,
                    TotalAmount = detailService
                        .GetDetailsByOrder(o.OrderID)
                        .Sum(d => d.UnitPrice * d.Quantity * (1 - (decimal)d.Discount))
                })
                .OrderByDescending(r => r.OrderDate)
                .ThenByDescending(r => r.OrderID)
                .ToList();

            dgReport.ItemsSource = data;
        }
    }
}

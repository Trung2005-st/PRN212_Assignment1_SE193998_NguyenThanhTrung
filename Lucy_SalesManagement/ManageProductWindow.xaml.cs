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
using DataAccessLayer;
using Services;

namespace Lucy_SalesManagement
{
    /// <summary>
    /// Interaction logic for ManageProductWindow.xaml
    /// </summary>
    public partial class ManageProductWindow : Window
    {
        private readonly ProductService productService = new ProductService();
        private bool isCompleted = false;

        public ManageProductWindow()
        {
            InitializeComponent();
            DisplayProducts();
        }

        private void DisplayProducts()
        {
            isCompleted = false;
            dgProducts.ItemsSource = productService.GetAllProducts();
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
                var p = new Product
                {
                    ProductID = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryID = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };

                bool added = productService.SaveProduct(p);
                if (added)
                {
                    dgProducts.ItemsSource = null;
                    dgProducts.ItemsSource = productService.GetAllProducts();
                }
                else
                {
                    MessageBox.Show("A product with the same ID already exists.",
                                    "Add Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product:\n" + ex.Message,
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
                var p = new Product
                {
                    ProductID = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryID = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };

                bool updated = productService.UpdateProduct(p);
                if (updated)
                {
                    dgProducts.ItemsSource = null;
                    dgProducts.ItemsSource = productService.GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Product not found or update failed.",
                                    "Update Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product:\n" + ex.Message,
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
                "Do you really want to delete this product?",
                "Confirm Delete",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result != MessageBoxResult.Yes)
                return;

            try
            {
                isCompleted = false;
                var p = new Product
                {
                    ProductID = int.Parse(txtProductID.Text)
                };

                bool deleted = productService.DeleteProduct(p);
                if (deleted)
                {
                    dgProducts.ItemsSource = null;
                    dgProducts.ItemsSource = productService.GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Product not found or delete failed.",
                                    "Delete Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product:\n" + ex.Message,
                                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                isCompleted = true;
            }
        }
        private void dgProducts_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (!isCompleted || e.AddedItems.Count <= 0)
                return;

            var p = e.AddedItems[0] as Product;
            if (p == null)
                return;

            txtProductID.Text = p.ProductID.ToString();
            txtProductName.Text = p.ProductName;
            txtCategoryID.Text = p.CategoryID.ToString();
            txtUnitPrice.Text = p.UnitPrice.ToString();
            txtUnitsInStock.Text = p.UnitsInStock.ToString();
        }
    }
}

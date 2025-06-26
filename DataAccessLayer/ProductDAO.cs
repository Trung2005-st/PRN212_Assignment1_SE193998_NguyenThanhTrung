using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        string connectionString = @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";
        Lucy_SalesDataDataContext context;

        public ProductDAO()
        {
            context = new Lucy_SalesDataDataContext(connectionString);
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.ToList();
        }

        public bool SaveProduct(Product c)
        {
            Product old = context.Products.FirstOrDefault(p => p.ProductID == c.ProductID);
            if (old != null)
            {
                return false;
            }
            context.Products.InsertOnSubmit(c);
            context.SubmitChanges();
            return true;
        }

        public bool DeleteProduct(Product c)
        {
            Product old = context.Products.FirstOrDefault(p => p.ProductID == c.ProductID);
            if (old != null)
            {
                context.Products.DeleteOnSubmit(c);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProduct(Product c)
        {
            Product old = context.Products.FirstOrDefault(p => p.ProductID == c.ProductID);
            if (old != null)
            {
                old.ProductID = c.ProductID;
                old.ProductName = c.ProductName;
                old.CategoryID = c.CategoryID;
                old.UnitPrice = c.UnitPrice;
                old.UnitsInStock = c.UnitsInStock;
                context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productDAO=new ProductDAO();
        public bool DeleteProduct(Product c)
        {
            return productDAO.DeleteProduct(c);
        }

        public List<Product> GetAllProducts()
        {
            return productDAO.GetAllProducts();
        }

        public bool SaveProduct(Product c)
        {
            return productDAO.SaveProduct(c);
        }

        public bool UpdateProduct(Product c)
        {
            return productDAO.UpdateProduct(c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class ProductService : IProductService
    {
        IProductRepository repository;

        public ProductService()
        {
            repository = new ProductRepository();
        }
        public bool DeleteProduct(Product c)
        {
            return repository.DeleteProduct(c);
        }

        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public bool SaveProduct(Product c)
        {
            return repository.SaveProduct(c);
        }

        public bool UpdateProduct(Product c)
        {
            return repository.UpdateProduct(c);
        }
    }
}

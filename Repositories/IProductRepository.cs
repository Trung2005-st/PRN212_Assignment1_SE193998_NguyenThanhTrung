using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
        public bool SaveProduct(Product c);
        public bool DeleteProduct(Product c);
        public bool UpdateProduct(Product c);

    }
}

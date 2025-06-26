using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Services
{
    public interface IOrderService
    {
        public List<Order> GetAllOrders();
        public bool SaveOrder(Order c);
        public bool DeleteOrder(Order c);
        public bool UpdateOrder(Order c);
    }
}

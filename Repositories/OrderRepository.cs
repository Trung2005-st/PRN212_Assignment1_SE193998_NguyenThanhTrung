using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        OrderDAO orderDAO=new OrderDAO();
        public bool DeleteOrder(Order c)
        {
            return orderDAO.DeleteOrder(c);
        }

        public List<Order> GetAllOrders()
        {
            return orderDAO.GetAllOrders();
        }

        public bool SaveOrder(Order c)
        {
            return orderDAO.SaveOrder(c);
        }

        public bool UpdateOrder(Order c)
        {
            return orderDAO.UpdateOrder(c);
        }
    }
}

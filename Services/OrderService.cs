using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class OrderService : IOrderService
    {
        IOrderRepository repository;

        public OrderService()
        {
            repository = new OrderRepository();
        }
        public bool DeleteOrder(Order c)
        {
            return repository.DeleteOrder(c);
        }

        public List<Order> GetAllOrders()
        {
            return repository.GetAllOrders();
        }

        public bool SaveOrder(Order c)
        {
           return repository.SaveOrder(c);
        }

        public bool UpdateOrder(Order c)
        {
            return repository.UpdateOrder(c);
        }
    }
}

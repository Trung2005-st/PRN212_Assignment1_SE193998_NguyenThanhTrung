using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class OrderDetailService : IOrderDetailService
    {
        IOrderDetailRepository repository;

        public OrderDetailService()
        {
            repository = new OrderDetailRepository();
        }
        public bool DeleteOrderDetail(Order_Detail c)
        {
           return repository.DeleteOrderDetail(c);
        }

        public List<Order_Detail> GetAllOrderDetails()
        {
            return repository.GetAllOrderDetails();
        }

        public List<Order_Detail> GetDetailsByOrder(int orderID)
        {
            return repository.GetDetailsByOrder(orderID);
        }

        public bool SaveOrderDetail(Order_Detail c)
        {
            return repository.SaveOrderDetail(c);
        }

        public bool UpdateOrderDetail(Order_Detail c)
        {
            return repository.UpdateOrderDetail(c);
        }
    }
}

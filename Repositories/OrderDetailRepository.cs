using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        OrderDetailDAO orderDetailDAO=new OrderDetailDAO();
        public bool DeleteOrderDetail(Order_Detail c)
        {
            return orderDetailDAO.DeleteOrderDetail(c);
        }

        public List<Order_Detail> GetAllOrderDetails()
        {
            return orderDetailDAO.GetAllOrderDetails();
        }

        public List<Order_Detail> GetDetailsByOrder(int orderID)
        {
            return orderDetailDAO.GetDetailsByOrder(orderID);
        }

        public bool SaveOrderDetail(Order_Detail c)
        {
           return orderDetailDAO.SaveOrderDetail(c);
        }

        public bool UpdateOrderDetail(Order_Detail c)
        {
           return orderDetailDAO.UpdateOrderDetail(c);
        }
    }
}

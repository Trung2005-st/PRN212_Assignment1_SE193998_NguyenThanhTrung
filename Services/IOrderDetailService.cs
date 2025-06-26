using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Services
{
    public interface IOrderDetailService
    {
        public List<Order_Detail> GetAllOrderDetails();
        public bool SaveOrderDetail(Order_Detail c);

        public bool DeleteOrderDetail(Order_Detail c);

        public bool UpdateOrderDetail(Order_Detail c);

        public List<Order_Detail> GetDetailsByOrder(int orderID);
    }
}

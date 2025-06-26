using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class OrderDetailDAO
    {
        string connectionString = @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";
        Lucy_SalesDataDataContext context;

        public OrderDetailDAO()
        {
            context = new Lucy_SalesDataDataContext(connectionString);
        }

        public List<Order_Detail> GetAllOrderDetails()
        {
            return context.Order_Details.ToList();
        }

        public List<Order_Detail> GetDetailsByOrder(int orderID)
        {
            var ls=context.Order_Details.Where(p=>p.OrderID==orderID).ToList();
            return ls;
        }

        public bool SaveOrderDetail(Order_Detail c)
        {
            Order_Detail old = context.Order_Details.FirstOrDefault(
                p => p.OrderID == c.OrderID && p.ProductID == c.ProductID);
            if (old != null)
            {
                return false;
            }
            context.Order_Details.InsertOnSubmit(c);
            context.SubmitChanges();
            return true;
        }

        public bool DeleteOrderDetail(Order_Detail c)
        {
            Order_Detail old = context.Order_Details.FirstOrDefault(
               p => p.OrderID == c.OrderID && p.ProductID == c.ProductID);
            if (old != null)
            {
                context.Order_Details.DeleteOnSubmit(c);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateOrderDetail(Order_Detail c)
        {
            Order_Detail old = context.Order_Details.FirstOrDefault(
                p => p.OrderID == c.OrderID && p.ProductID == c.ProductID);
            if (old != null)    
            {
                old.OrderID = c.OrderID;
                old.ProductID = c.ProductID;
                old.UnitPrice = c.UnitPrice;
                old.Quantity = c.Quantity;
                old.Discount = c.Discount;
                context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}

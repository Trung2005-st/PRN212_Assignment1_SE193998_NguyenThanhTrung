using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class OrderDAO
    {
        string connectionString = @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";
        Lucy_SalesDataDataContext context;

        public OrderDAO()
        {
            context = new Lucy_SalesDataDataContext(connectionString);
        }

        public List<Order> GetAllOrders()
        {
            return context.Orders.ToList();
        }

        public bool SaveOrder(Order c)
        {
            Order old = context.Orders.FirstOrDefault(p => p.OrderID == c.OrderID);
            if (old != null)
            {
                return false;
            }
            context.Orders.InsertOnSubmit(c);
            context.SubmitChanges();
            return true;
        }

        public bool DeleteOrder(Order c)
        {
            Order old = context.Orders.FirstOrDefault(p => p.OrderID == c.OrderID);
            if (old != null)
            {
                context.Orders.DeleteOnSubmit(c);
                context.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateOrder(Order c)
        {
            Order old = context.Orders.FirstOrDefault(p => p.OrderID == c.OrderID);
            if (old != null)
            {
                old.OrderID = c.OrderID;
                old.CustomerID = c.CustomerID;
                old.EmployeeID = c.EmployeeID;
                old.OrderDate = c.OrderDate;
                context.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
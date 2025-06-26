using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        private readonly string connectionString =
            @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";

        private readonly Lucy_SalesDataDataContext context;

        public CustomerDAO()
        {
            context = new Lucy_SalesDataDataContext(connectionString);
        }

        public List<Customer> GetAllCustomers()
        {
            return context.Customers.ToList();
        }

        public bool GetCustomer(Customer c)
        {
            Customer old= context.Customers.FirstOrDefault(p=>p.Phone.Equals(c.Phone));
            if (old != null)
            {
                return true;
            }
            return false;
        }

        public bool SaveCustomer(Customer c)
        {
            var old = context.Customers
                             .FirstOrDefault(p => p.CustomerID == c.CustomerID);

            if (old != null)
                return false;

            context.Customers.InsertOnSubmit(c);
            context.SubmitChanges();
            return true;
        }

        public bool DeleteCustomer(Customer c)
        {
            var old = context.Customers
                             .FirstOrDefault(p => p.CustomerID == c.CustomerID);

            if (old != null)
            {
                context.Customers.DeleteOnSubmit(old);
                context.SubmitChanges();
                return true;
            }

            return false;
        }

        public bool UpdateCustomer(Customer c)
        {
            var old = context.Customers
                             .FirstOrDefault(p => p.CustomerID == c.CustomerID);

            if (old != null)
            {
                // Note: CustomerID usually shouldn't be updated
                old.CompanyName = c.CompanyName;
                old.ContactName = c.ContactName;
                old.ContactTitle = c.ContactTitle;
                old.Address = c.Address;
                old.Phone = c.Phone;

                context.SubmitChanges();
                return true;
            }

            return false;
        }
    }
}

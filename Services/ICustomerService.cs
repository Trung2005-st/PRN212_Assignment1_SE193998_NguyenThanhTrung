using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Services
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomers();
        public bool SaveCustomer(Customer c);

        public bool DeleteCustomer(Customer c);
        public bool UpdateCustomer(Customer c);

        public bool GetCustomer(Customer c);
    }
}

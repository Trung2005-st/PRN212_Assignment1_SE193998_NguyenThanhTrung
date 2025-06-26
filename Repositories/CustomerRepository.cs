using System.Collections.Generic;
using DataAccessLayer;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerDAO _dao;

        public CustomerRepository()
        {
            _dao = new CustomerDAO();
        }

        public List<Customer> GetAllCustomers()
        {
            return _dao.GetAllCustomers();
        }

        public bool SaveCustomer(Customer c)
        {
            return _dao.SaveCustomer(c);
        }

        public bool DeleteCustomer(Customer c)
        {
            return _dao.DeleteCustomer(c);
        }

        public bool UpdateCustomer(Customer c)
        {
            return _dao.UpdateCustomer(c);
        }

        public bool GetCustomer(Customer c)
        {
            return _dao.GetCustomer(c);
        }
    }
}

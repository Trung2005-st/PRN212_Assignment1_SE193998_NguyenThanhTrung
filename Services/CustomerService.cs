using DataAccessLayer;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        CustomerDAO customerDAO=new CustomerDAO();
        public bool DeleteCustomer(Customer c)
        {
            return customerDAO.DeleteCustomer(c);
        }

        public List<Customer> GetAllCustomers()
        {
            return customerDAO.GetAllCustomers();
        }

        public bool SaveCustomer(Customer c)
        {
            return customerDAO.SaveCustomer(c);
        }

        public bool UpdateCustomer(Customer c)
        {
            return customerDAO.UpdateCustomer(c);
        }

        public bool GetCustomer(Customer c)
        {
            return customerDAO.GetCustomer(c);
        }
    }
}

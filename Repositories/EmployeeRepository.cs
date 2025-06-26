using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        EmployeeDAO employeeDAO= new EmployeeDAO();
        public bool DeleteEmployee(Employee c)
        {
            return employeeDAO.DeleteEmployee(c);
        }

        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        public bool GetEmployee(Employee e)
        {
            return employeeDAO.GetEmployee(e);
        }

        public bool SaveEmployee(Employee c)
        {
            return employeeDAO.SaveEmployee(c);
        }

        public bool UpdateEmployee(Employee c)
        {
            return employeeDAO.UpdateEmployee(c);
        }
    }
}

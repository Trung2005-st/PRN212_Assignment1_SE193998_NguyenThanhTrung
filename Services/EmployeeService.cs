using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Repositories;

namespace Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository iEmployeeRepository;

        public EmployeeService()
        {
            iEmployeeRepository = new EmployeeRepository();
        }
        public bool DeleteEmployee(Employee c)
        {
            return iEmployeeRepository.DeleteEmployee(c);
        }

        public List<Employee> GetAllEmployees()
        {
            return iEmployeeRepository.GetAllEmployees();
        }

        public bool GetEmployee(Employee e)
        {
            return iEmployeeRepository.GetEmployee(e);
        }

        public bool SaveEmployee(Employee c)
        {
            return iEmployeeRepository.SaveEmployee(c);
        }

        public bool UpdateEmployee(Employee c)
        {
            return iEmployeeRepository.UpdateEmployee(c);
        }
    }
}

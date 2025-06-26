using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IEmployeeService
    {
        public List<DataAccessLayer.Employee> GetAllEmployees();
        public bool GetEmployee(DataAccessLayer.Employee e);
        public bool SaveEmployee(DataAccessLayer.Employee c);

        public bool DeleteEmployee(DataAccessLayer.Employee c);

        public bool UpdateEmployee(DataAccessLayer.Employee c);
    }
}

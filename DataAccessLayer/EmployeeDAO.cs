using BusinessObject;
using DataAccessLayer;

public class EmployeeDAO
{
    string connectionString = @"server=localhost;database=Lucy_SalesData;uid=trungcmnr;pwd=Cmnr123456@";
    Lucy_SalesDataDataContext context;

    public EmployeeDAO()
    {
        context = new Lucy_SalesDataDataContext(connectionString);
    }

    public List<DataAccessLayer.Employee> GetAllEmployees()
    {
        return context.Employees.ToList();
    }

    public bool GetEmployee(DataAccessLayer.Employee e)
    {
        DataAccessLayer.Employee old= context.Employees.FirstOrDefault(p=>p.UserName.Equals(e.UserName) && p.Password.Equals(e.Password));
        if (old != null) {
            return true;
        }
        return false;
    }

    public bool SaveEmployee(DataAccessLayer.Employee c)
    {
        DataAccessLayer.Employee old = context.Employees.FirstOrDefault(p => p.EmployeeID == c.EmployeeID);
        if (old != null)
        {
            return false;
        }
        context.Employees.InsertOnSubmit(c);
        context.SubmitChanges();
        return true;
    }

    public bool DeleteEmployee(DataAccessLayer.Employee c)
    {
        DataAccessLayer.Employee old = context.Employees.FirstOrDefault(p => p.EmployeeID == c.EmployeeID);
        if (old != null)
        {
            context.Employees.DeleteOnSubmit(c);
            context.SubmitChanges();
            return true;
        }
        return false;
    }

    public bool UpdateEmployee(DataAccessLayer.Employee c)
    {
        DataAccessLayer.Employee old = context.Employees.FirstOrDefault(p => p.EmployeeID == c.EmployeeID);
        if (old != null)
        {
            old.EmployeeID = c.EmployeeID;
            old.Name = c.Name;
            old.UserName = c.UserName;
            old.Password = c.Password;
            old.JobTitle = c.JobTitle;
            context.SubmitChanges();
            return true;
        }
        return false;
    }
}
using ApiEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDataAccess.Interface
{
    public interface IEmployeeDataAccess
    {
        List<Employee> GetEmployee();
        List<LoginCredentials> GetUsers();
        int DeleteEmployee(long EmployeeId);
        int AddEmployee(Employee emp);
        
    }
}

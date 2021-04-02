using ApiEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBusinessLayer.Interface
{
    public interface IEmployeeComponent
    {
        List<Employee> GetEmployee();

        List<LoginCredentials> GetUsers();
        int DeleteEmployee(long EmployeeId);
        int AddEmployee(Employee emp);
    }
}

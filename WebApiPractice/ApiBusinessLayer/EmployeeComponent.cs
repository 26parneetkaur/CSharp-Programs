using ApiBusinessLayer.Interface;
using ApiDataAccess.Interface;
using ApiEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiBusinessLayer
{
    public class EmployeeComponent : IEmployeeComponent
    {
        private readonly IEmployeeDataAccess _employeedata;

        public EmployeeComponent(IEmployeeDataAccess employeedata)
        {
            _employeedata = employeedata;
        }

        public int AddEmployee(Employee emp)
        {
            return _employeedata.AddEmployee(emp);
        }

        public int DeleteEmployee(long EmployeeId)
        {
            return _employeedata.DeleteEmployee(EmployeeId);
        }

        public List<Employee> GetEmployee()
        {
            return _employeedata.GetEmployee();
        }

        public List<LoginCredentials> GetUsers()
        {
            return _employeedata.GetUsers();
        }
    }
}

using ApiDataAccess.Interface;
using ApiEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiDataAccess
{
    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly EmployeeDbContext _context;
        public EmployeeDataAccess(EmployeeDbContext context)
        {
            _context = context;
        }

        public int AddEmployee(Employee emp)
        {
            _context.Employee.Add(emp);
            return _context.SaveChanges();
        }

        public int DeleteEmployee(long EmployeeId)
        {
            Employee std = _context.Employee.FirstOrDefault(x => x.EmployeeId == EmployeeId);
            _context.Employee.Remove(std);
            return _context.SaveChanges();
        }

        public List<Employee> GetEmployee()
        {
            return _context.Employee.ToList();
        }

        public List<LoginCredentials> GetUsers()
        {
            return _context.LoginCredentials.ToList();
        }
    }
}

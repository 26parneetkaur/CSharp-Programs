using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public long Salary { get; set; }
        public string Designation { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public long ContactNo { get; set; }
        public string Department { get; set; }
    }
}

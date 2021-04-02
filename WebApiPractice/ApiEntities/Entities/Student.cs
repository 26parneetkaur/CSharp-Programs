using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentGender { get; set; }
        public DateTime StudentDob { get; set; }
        public int StudentAge { get; set; }
        public string State { get; set; }
        public long TeacherId { get; set; }
        public long CollegeId { get; set; }

        public virtual College College { get; set; }
    }
}

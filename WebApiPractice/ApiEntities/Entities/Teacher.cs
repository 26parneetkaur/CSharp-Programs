using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class Teacher
    {
        public long TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherGender { get; set; }
        public int TeacherAge { get; set; }
        public string TeacherEmail { get; set; }
        public string Subjects { get; set; }
        public long CollegeId { get; set; }

        public virtual College College { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class DataView
    {
        public long StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public int StudentAge { get; set; }
        public string CollegeName { get; set; }
        public string TeacherName { get; set; }
        public string UniversityName { get; set; }
    }
}

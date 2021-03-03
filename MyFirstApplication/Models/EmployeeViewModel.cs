using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyFirstApplication.Models
{
    public class EmployeeViewModel
    {
        public long Id
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Provide Name")]
        public string Name
        {
            get; set;
        }
        [Required(ErrorMessage ="Please provide Age")]
        [Range(0,70,ErrorMessage="Please Provide Valid Age")]
        [RegularExpression("^[0-9]*$")]
        public string Age
        {
            get; set;
        }
        [Required(ErrorMessage ="Please provide Salary")]
        public string Salary
        {
            get; set;
        }
        [Required(ErrorMessage ="Please mention Designation")]
        public string Designation
        {
            get; set;
        }
        [Required]
        public string Edit
        {
            get; set;
        }
        public bool isActive
        {
            get; set;
        }
        public string Gender
        {
            get; set;
        }
        public string Password 
        { get; set; }

        public string Email
        {
            get; set;
        }
        public int TypeGender
        {
            get; set;
        }
        public int[] Country
        {
            get; set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Student
    {
        public int ID { get; set; }
        [Required]
        public string ?FirstName { get; set; }
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Age { get; set; }
        public int DepartmentID { get; set; }
       
    }
}

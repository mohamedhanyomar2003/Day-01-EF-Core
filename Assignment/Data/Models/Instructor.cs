using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Instructor
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; } 
        [Column(TypeName ="decimal(12,2)")]
        public double Salary { get; set; }
        [StringLength(50)]
        public string Address { get; set; } = null!;
        public int HourRate { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public double Bonus { get; set; }
        public int DepartmentID { get; set; }


    }
}

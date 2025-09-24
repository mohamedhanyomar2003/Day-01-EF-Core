using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Department
    {
        public int ID { get; set; }
        [Required]
        public string? Name { get; set; }
        public int InstructorID { get; set; }
        public DateOnly Date { get; set; }

    }
}

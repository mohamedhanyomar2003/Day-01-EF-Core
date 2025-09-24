using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        [Required]
        public string ?Name { get; set; }
        public string Description { get; set; } = null!;
        public int TopID { get; set; }
    }
}

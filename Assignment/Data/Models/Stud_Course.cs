using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    [PrimaryKey(nameof(StudentID),nameof(CourseID))]
    class Stud_Course
    {
      
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public decimal Grade { get; set; }
    }
}

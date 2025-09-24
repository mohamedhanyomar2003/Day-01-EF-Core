using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    [PrimaryKey(nameof(InstructorID), nameof(CourseID))]
    class Course_Inst
    {
        public int InstructorID { get; set; }
        public int CourseID { get; set; }
        public string? Evaluate { get; set; }
    }
}

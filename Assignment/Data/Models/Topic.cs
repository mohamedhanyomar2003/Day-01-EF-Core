using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Data.Models
{
    class Topic
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

    }
}

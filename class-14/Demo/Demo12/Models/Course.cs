using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string CourseCode { get; set; }

        public decimal Price { get; set; }
    }
}

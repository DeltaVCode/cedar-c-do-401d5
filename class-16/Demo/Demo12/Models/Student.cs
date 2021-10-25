using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        // Nullable<DateTime> is optional!
        public DateTime? DateOfBirth { get; set; }
        

        // Reverse Navigation Properties
        public List<Enrollment> Enrollments { get; set; }

        public List<Transcript> Grades { get; set; }
    }
}

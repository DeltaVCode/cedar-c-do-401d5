using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public class Enrollment
    {
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        // Navigation Properties that create a Foreign Key relationship
        // Linked to CourseId/StudentId by naming convention PropId
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}

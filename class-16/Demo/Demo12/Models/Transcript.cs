using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Models
{
    public class Transcript
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Grade Grade { get; set; }
        
        // Navigation Properties to make our FKs
        public Course Course { get; set; }
        public Student Student { get; set; }
    }

    public enum Grade
    {
        A,
        B,
        C,
        D,
        F,
    }
}

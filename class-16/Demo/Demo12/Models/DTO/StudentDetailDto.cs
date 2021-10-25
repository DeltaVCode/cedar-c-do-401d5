using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Models.DTO
{
    public class StudentDetailDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }

        public List<CourseSummary> EnrolledCourses { get; set; }

        public List<TranscriptDto> Grades { get; set; }
    }
}

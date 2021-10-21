using Demo12.Data;
using Demo12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services.Database
{
    public class DatabaseStudentRepository : IStudentRepository
    {
        private readonly SchoolDbContext _context;

        public DatabaseStudentRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task EnrollStudent(int studentId, int courseId)
        {
            var enrollment = new Enrollment
            {
                StudentId = studentId,
                CourseId = courseId,
            };

            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAll()
        {
            var result = await _context.Students
                // Go get all of each Student's Enrollments
                .Include(s => s.Enrollments)
                // And also include each Enrollment's Course
                .ThenInclude(e => e.Course)
                .ToListAsync();

            return result;

            //return new List<Student>
            //{
            //    new Student { FirstName = "Keith" },
            //};
        }
    }
}

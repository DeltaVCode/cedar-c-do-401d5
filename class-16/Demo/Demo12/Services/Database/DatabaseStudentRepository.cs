using Demo12.Data;
using Demo12.Models;
using Demo12.Models.DTO;
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

        public async Task DropStudent(int studentId, int courseId)
        {
            var enrollment = await _context.Enrollments
                // WRONG KEY ORDER!!!!
                // .FindAsync(studentId, courseId);
                // Correct order!
                // .FindAsync(courseId, studentId);
                // Better to be explicit:
                .FirstOrDefaultAsync(e =>
                    e.CourseId == courseId &&
                    e.StudentId == studentId);

            // TODO: Handle enrollment not found more gracefully, e.g. return false

            _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
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

        public async Task<List<StudentDetailDto>> GetAll()
        {
            var result = await _context.Students
                // Go get all of each Student's Enrollments
                .Include(s => s.Enrollments)
                // And also include each Enrollment's Course
                .ThenInclude(e => e.Course)

                .Select(student => new StudentDetailDto
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    DisplayName = student.FirstName + " " + student.LastName,

                    EnrolledCourses = student.Enrollments
                        .Select(e => new CourseSummary
                        {
                            Id = e.CourseId,
                            Code = e.Course.CourseCode,
                        })
                        .ToList(), // have to convert to list

                    Grades = student.Grades
                        .Select(transcript => new TranscriptDto
                        {
                            CourseCode = transcript.Course.CourseCode,
                            Grade = transcript.Grade.ToString(),
                        })
                        .ToList(),
                })
                .ToListAsync();

            return result;

            //return new List<Student>
            //{
            //    new Student { FirstName = "Keith" },
            //};
        }
    }
}

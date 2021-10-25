using Demo12.Data;
using Demo12.Models;
using Demo12.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services.Database
{
    public class DatabaseCourseRepository : ICourseRepository
    {
        private readonly SchoolDbContext _context;

        public DatabaseCourseRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public Task<List<CourseSummary>> GetAll()
        {
            return _context.Courses
                .Select(course => new CourseSummary
                {
                    // Copy properties from Course to CourseSummary
                    Id = course.Id,
                    Code = course.CourseCode,
                })
                .ToListAsync();
        }

        public Task<Course> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task Insert(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> TryUpdate(Course course)
        {
            _context.Entry(course).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseExists(course.Id))
                {
                    // return NotFound();
                    return false;
                }
                else
                {
                    throw;
                }
            }

            // return NoContent();
            return true;
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.Id == id);
        }
    }
}

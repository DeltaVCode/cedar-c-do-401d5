using Demo12.Models;
using Demo12.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo12.Services
{
    public interface IStudentRepository
    {
        // Promise to return a List of Student objects
        Task<List<StudentDetailDto>> GetAll();

        Task EnrollStudent(int studentId, int courseId);
        Task DropStudent(int studentId, int courseId);
    }
}

using Demo12.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo12.Services
{
    public interface IStudentRepository
    {
        // Promise to return a List of Student objects
        Task<List<Student>> GetAll();
    }
}

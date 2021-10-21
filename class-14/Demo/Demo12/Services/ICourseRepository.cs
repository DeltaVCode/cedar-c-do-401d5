using Demo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services
{
    public interface ICourseRepository
    {
        Task Insert(Course course);
    }
}

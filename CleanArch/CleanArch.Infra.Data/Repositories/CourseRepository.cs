using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UnivDbContext univDbContext;

        public CourseRepository(UnivDbContext univDbContext)
        {
            this.univDbContext = univDbContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return univDbContext.courses; 
        }
    }
}

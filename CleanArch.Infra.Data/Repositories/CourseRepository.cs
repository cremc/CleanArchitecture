using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private QuedDBContext _context;
        //private ILogger _logger;

        public CourseRepository(QuedDBContext context)
        {
            _context = context;
           // _logger = logger;
        }
        public IEnumerable<Course> GetCourses()
        {

            //_logger.LogInformation(_context.Database.ProviderName);

            //var query = _context.Database

            return _context.Courses;
        }

        public void AddNew(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }
    }
}

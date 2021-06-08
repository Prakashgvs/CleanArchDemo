using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICouseService
    {
        private ICourseRepository _courserepository;
        public CourseService(ICourseRepository courserepository)

        {
            _courserepository = courserepository;

        }

        public CourseViewModel  GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courserepository.GetCourses()

            };
        }
    }
}

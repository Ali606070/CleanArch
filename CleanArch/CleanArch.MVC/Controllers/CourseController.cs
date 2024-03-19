using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService  courseService)
        {
            this.courseService = courseService;
        }
        public IActionResult Index()
        {
            CoursViewModel coursViewModel = courseService.GetCourses();

            return View(coursViewModel);
        }
    }
}

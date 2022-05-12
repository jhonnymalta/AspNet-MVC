using _002_Portfolio.Models;
using _002_Portfolio.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace _002_Portfolio.Controllers
{
    public class CursosController : Controller
    {
        private readonly IRepositoryCourses repositoryCourses;

        public CursosController(IRepositoryCourses repositoryCourses)
        {
            this.repositoryCourses = repositoryCourses;
        }
        public IActionResult Index()
        {
            var courser = repositoryCourses.GetCourses();
            var modelo = new ListCoursesViewModel() { coursesList = courser };
            return View(modelo);
        }
        
        
    }
}

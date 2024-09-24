using Microsoft.AspNetCore.Mvc;

namespace Level2_1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details()
        {
            return View();
        }
    }
}

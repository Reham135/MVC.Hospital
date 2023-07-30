using Microsoft.AspNetCore.Mvc;

namespace Hospital.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

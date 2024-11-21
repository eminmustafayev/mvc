using Microsoft.AspNetCore.Mvc;

namespace uniqilo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

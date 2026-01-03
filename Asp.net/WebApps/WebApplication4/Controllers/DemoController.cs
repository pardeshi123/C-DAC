using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

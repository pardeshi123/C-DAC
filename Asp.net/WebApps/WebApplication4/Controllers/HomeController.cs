using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        ActionResult<string> UserCredentials(string username, string password)
        {
            return $"Username={username} Password={password}";
            
        }
    }
}

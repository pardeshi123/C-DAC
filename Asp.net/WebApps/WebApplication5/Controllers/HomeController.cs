using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        //[Route(" ")]
        //[Route("~/")]
        [Route("Index")]   
        public IActionResult Index()
        {   
            
            return View();
        }
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

    }
}

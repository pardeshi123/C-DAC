using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace WebApplication5.Controllers
{
    [Route("Admin")]
    public class DemoController1 : Controller
    {
        [Route("Demo")]
        public IActionResult Demo()
        {
            return View("~/Views/Demo/Demo.cshtml");
        }
        [Route("Greet")]
        public string sayHi()
        {
            return "Hello";
        }
    }
}

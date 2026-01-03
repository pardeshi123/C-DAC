using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.message = "Hello Guysss!";

            Emp emp = new Emp() { Id = 101, Name = "Snehal", Address = "Pune" };
            ViewBag.empInfo = emp;

            ViewData["number"] = 145;

            Emp emp1 = new Emp() { Id = 12, Name = "Aditi", Address = "Mumbai" };
            ViewData["emp1"] = emp1;

            TempData["PIN"] = 321543;

            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult ABCD()
        {
            return View();
        }
    }
}
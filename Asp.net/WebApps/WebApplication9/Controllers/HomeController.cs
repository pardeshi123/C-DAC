using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetNewUserDetails(NewUser newuser)//Model Binder
        {
            return View(newuser);
        }
    }
}

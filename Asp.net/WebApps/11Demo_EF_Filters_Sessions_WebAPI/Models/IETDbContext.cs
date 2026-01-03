using Microsoft.AspNetCore.Mvc;

namespace _11Demo_EF_Filters_Sessions_WebAPI.Models
{
    public class IETDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

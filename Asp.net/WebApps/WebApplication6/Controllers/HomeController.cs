using Microsoft.AspNetCore.Mvc;

namespace _06Demo_ReturnTypesOfActionMethod.Controllers
{
    public class HomeController : Controller
    {
        // Most Flexible ReturnType : Comman Type
        public IActionResult Index()
        {
            return View();
        }
        // Most common Return Type in old MVC version(Standard .Net)
        public ActionResult About()
        {
            return View();
        }
        // Strongly -typed return type of Method : Generic Type<T>
        public ActionResult<int> GetNumber()
        {
            return 1111;
        }
        public ViewResult M1()
        {
            return View("~/Views/Home/About.cshtml");
        }
        public string GetSomething(string unm, string pwd)
        {
            return $"{unm} {pwd}";
        }
        public JsonResult getData(){
            var data = new
            {
                id = 101,
                name = "Snehal",
                Adress = "Pune"
            };
            return Json(data);
        }
        public ObjectResult GetObject()
        {
            var obj = new
            {
                ID = 101,
                Name = "Hugh Jackman",
                Address = "NYC"
            };
            return new ObjectResult(obj); //in . net it is converting the object into json using serialization here no need to use4 json(obj) function 
        }

        public FileResult DownloadFile()
        { var byteArray = System.IO.File.ReadAllBytes("C:\\Users\\IET\\Desktop\\Asp.net\\WebApps\\WebApplication6\\Data\\Screeonshot.pdf");
            return File(byteArray, "application/pdf", "Screeonshot.pdf");
        }
    }
}

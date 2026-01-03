using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace WebApplication5.Controllers
{
    [Route("[controller]")]
    public class DashboardController : Controller
    {
  
        [Route("[action]")]
        public int getNumber() {
            return 100;
        }
        [Route("[action]/{id?}/{nm?}")]
        public string getPassword(int id, string nm)
        {
            return $"id={id} name={nm}";
        }

    }
}

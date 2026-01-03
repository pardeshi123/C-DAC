using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Diagnostics;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        List<Emp> EmpList = new List<Emp>() {
        new Emp() { Id = 101, Name = "Snehal", Address = "Jalana"},
        new Emp() { Id = 102, Name = "Ashwini",Address = "Nashik"},
        new Emp() { Id = 103, Name = "Kartiki",Address = "Mumbai"},
        new Emp() { Id = 104, Name = "Naina",Address = "Satara"},
        new Emp() { Id = 105, Name = "Yogini",Address = "Kolhapur"},


        };

        List<Customer> CustList = new List<Customer>()
        {
            new Customer() {cid=11,cname="Ashok",billNo=90},
            new Customer() {cid=12,cname="Asmita",billNo=70},
            new Customer() {cid=13,cname="Rohini",billNo=30},
        };
        public IActionResult Index()
        {
            long phNo = 8275006278;
            return View(phNo);
         
        }
         
        public IActionResult GetEmps()
        {
            return View(EmpList);
        }

        public IActionResult GetRecords()
        {
            IETDbViewModel vmmodel = new IETDbViewModel() {
                allEmps = EmpList,
                allCust = CustList
            };
            return View(vmmodel);
        } 
        public IActionResult Display()
        {
            Emp emp = new Emp() { Id = 1, Name = "Shital", Address = "Patana" };
            Customer cust = new Customer() { cid = 2, cname = "Ankita", billNo = 80 }; 
            ArrayList arr = new ArrayList() { emp,cust };
            return View(arr);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

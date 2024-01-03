using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Net;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
         public IActionResult Index()
            {
                return View();
            }    
            [HttpPost]
         public IActionResult Index(Employee emp)
            {
                string str = emp.FullName + "_" + emp.Age ; 
                ViewBag.KetQua = str;
                return View();

            }
    }
}            
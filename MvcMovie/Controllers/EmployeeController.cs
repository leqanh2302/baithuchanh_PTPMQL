using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Net;

namespace DemoMVC.Controllers
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
                string str = emp.FullName + "_" + emp.EmployeeID + "_" + emp.SoDienThoai +"_"+ emp.Address; 
                ViewBag.KetQua = str;
                return View();

            }
    }
}            
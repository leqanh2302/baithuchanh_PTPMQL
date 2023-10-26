using System.IO.Pipes;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
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
            string strResult = "Hello: " + emp.fullname + "-"+emp.MaNV + "-" + emp.TuoiNV + "-" + emp.Luong;
            ViewBag.thongbao = strResult;
            return View();
        }
        
    }
}
//Le Quynh Anh_2021050074
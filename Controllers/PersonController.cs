using System.IO.Pipes;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
          return View();  
        }
        [HttpPost]
        public IActionResult Index(Person ps )
        {
            string strResult = "Hello"+ ps.PersonID+"-"+ps.Fullname;
            ViewBag.thongbao = strResult;
            return View();
        }
        
    }
}
//Le Quynh Anh_2021050074
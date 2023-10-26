using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int personID, string fullname)
        {
            string str = "Hello" + personID + "-" + fullname; 
            ViewBag.thongbao = str;
            return View();
        }
    }

}

//Le Quynh Anh_2021050074
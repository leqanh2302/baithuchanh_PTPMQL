using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class BTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string HoTen, int HSluong, int PhuCap, int Luongcb )
        {
            string str = "Hello" + HoTen; 
            int Luong = Luongcb*HSluong+PhuCap;
            ViewBag.thongbao = str;
            return View();
        }
    }

}

//Le Quynh Anh_2021050074
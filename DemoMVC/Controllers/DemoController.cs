using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string fname,string Email)
        {
            string strResult = "Hello:" + fname + "-" + Email;
            ViewBag.Thongbao = strResult;
            return View();


        }
    }
}


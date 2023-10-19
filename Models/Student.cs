using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;
namespace DemoMVC.Model
{
    public class Student 
    {
        public int personID {get; set;}
        public string fullname {get; set;}
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int personID, String fullname)
        {
            string str = "Hello" + personID + "-" + fullname; 
            ViewBag.Thongbao = str;
            return View();
    
        }

    }
}

//Le Quynh Anh_2021050074
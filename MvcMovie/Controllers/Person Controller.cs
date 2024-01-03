using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System.Net;

namespace DemoMVC.Controllers
{
    public class PersonController:Controller
    {
        public IActionResult Index()
        {
             return View();
        }    
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string strOutput = "Xin chao" + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.infoPerson = strOutput;
            return View();

        }

    }
}
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
        string str = "hello " +  ps.PersonID + " " + ps.FullName;
        ViewBag.ThongBao = str;
        return View();
    }

}
}
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string Fullname, string Address)
    {
        String strOutput = "Xin chao" + Fullname + "den tu" + Address;
        ViewBag.Message = strOutput;
        return View();
    }
}
//Le Quynh Anh_2021050074
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewMVCApp.Models;

namespace NewMVCApp.Controllers;

public class HelloWorldController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

   public string Welcome(){
    return "Day la trang hello world";
   }
}

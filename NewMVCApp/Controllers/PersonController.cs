using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewMVCApp.Models;

namespace NewMVCApp.Controllers;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
   public IActionResult Index(Person ps){
        string output = "Xin chào bạn:" + ps.PersonId + "___" + ps.Fullname + "___" + ps.Address;
        ViewBag.infoPerson = output;
        return View();
   }
}

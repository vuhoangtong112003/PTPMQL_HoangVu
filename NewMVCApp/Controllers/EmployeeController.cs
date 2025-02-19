using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewMVCApp.Models;

namespace NewMVCApp.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
   public IActionResult Index(Employee employee){
        string output = "Xin chào nhân viên " + employee.EmployeeId + "__" + employee.Fullname + "__" + employee.Age + "__" + employee.Address;
        ViewBag.inforEmployee = output;
        return View();
   }
}

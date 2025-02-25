using Microsoft.AspNetCore.Mvc;
using NewMVCApp.Models;
namespace NewMVCApp.Controllers
{
    public class BMIController : Controller
    { 
        // GET: /BMI/
        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Index(BMI bmi)
        {
            if (bmi.cannang > 0 && bmi.chieucao > 0)
            {
                double ketqua = bmi.cannang / (bmi.chieucao * bmi.chieucao);
                string xephang = ketqua < 18.5 ? "Gầy" :
                                  ketqua < 24.9 ? "Bình Thường" :
                                  ketqua < 29.9 ? "Béo phì" :
                                  "Béo phì nặng"; 
                
                ViewBag.BMI = ketqua.ToString("0.00");
                ViewBag.Category = xephang;
            }
            return View();
        }
    }
}
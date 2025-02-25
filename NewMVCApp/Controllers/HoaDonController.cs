using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using NewMVCApp.Models;
namespace NewMVCApp.Controllers
{
    public class HoaDonController : Controller
    { 
        // GET: /HoaDon/
        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Index(HoaDon bill){
            int tong = bill.SoLuong * bill.DonGia;
            ViewBag.HoaDon = tong;
            return View();
        }
    }
}
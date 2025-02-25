using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using NewMVCApp.Models;
namespace NewMVCApp.Controllers
{
    public class DiemController : Controller
    { 
        // GET: /Sunm/
       
        public IActionResult Index() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Diem diem){
            if (diem.A > 0 && diem.B > 0 && diem.C > 0){
                double Tong = (diem.A * 0.6) + (diem.B * 0.3) + (diem.C * 0.1);
                string HocLuc;

                if (Tong >= 9.0)
                    HocLuc = "Xuất sắc";
                else if (Tong >= 8.0)
                    HocLuc = "Giỏi";
                else if (Tong >= 6.5)
                    HocLuc = "Khá";
                else if (Tong >= 5.0)
                    HocLuc = "Trung bình";
                else if (Tong >= 3.5)
                    HocLuc = "Yếu";
                else
                    HocLuc = "Kém";

                ViewBag.Tong = Tong.ToString("0.00");
                ViewBag.HocLuc = HocLuc;
            }
            return View();
        }
    }

}
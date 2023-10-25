using System.ComponentModel.Design;
using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        //khoi tao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Hoten, double hsl,int pc)
        {
           int LuongCoBan = 5000000;
           int Luong = Convert.ToInt32( LuongCoBan * hsl + pc);
           string FormResult ="Nhan vien " + Hoten + " co muc luong la: " + Luong;
            ViewBag.Noti = FormResult;
            return View();
        }
        
    }
}
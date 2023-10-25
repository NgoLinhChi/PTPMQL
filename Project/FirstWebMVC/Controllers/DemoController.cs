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
        public IActionResult Index(double HSa,double HSb)
        {
           string phuongtrinh = "Phuong trinh da nhap la: " + HSa + "x +"  + HSb + " = 0";
           string FormResult;
           if (HSa ==0) 
           {
                FormResult = "Phuong trinh vo nghiem.";
            }
            else
            {
                FormResult = "Phuong trinh co nghiem x = " + (-HSb / HSa);
            }
           
            ViewBag.debai=phuongtrinh;
            ViewBag.Noti = FormResult;
            return View();
        }
        
    }
}
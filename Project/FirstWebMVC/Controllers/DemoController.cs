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
        public IActionResult Index(double HSa,double HSb,double HSc)
        {
           string phuongtrinh = "Phuong trinh da nhap la: " + HSa + "x^2 + " + HSb + "x +" + HSc + " = 0";
           string FormResult;
           double delta = HSb * HSb + 4 * HSa * HSc;
           double x1,x2;
           if (HSa ==0) 
           {
            if (HSb == 0)
            {
                FormResult = "Phuong trinh vo nghiem.";
            }
            else
            {
                FormResult = "Phuong trinh co nghiem x = " + (-HSc / HSb);
            }
           }
            else if (delta > 0)
            {
                x1 = (double)((HSb + Math.Sqrt(delta)) /2 * HSa);
                x2= (double)((HSb - Math.Sqrt(delta)) /2 * HSa);
                FormResult = "Phuong trinh co 2 nghiem là x1 = " + x1 + " va x2 = " + x2;
            }
            else if (delta == 0)
            {
                x1= (-HSb/(2*HSa));
                FormResult= "Phuong trinh co nghiem kep x1 = x2 = " + x1;
            }
            else
            {
                FormResult = "Phuong trinh vo nghiem.";
            }
            ViewBag.debai=phuongtrinh;
            ViewBag.Noti = FormResult;
            return View();
        }
        
    }
}
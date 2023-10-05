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
        public IActionResult Index(string Fullname, string Email)
        {
            string FormResult = "Xin chao " + Fullname + " - " + Email;
            ViewBag.Noti = FormResult;
            return View();
        }
        
    }
}

using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers
{
    public class PersonController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            string Result= "Xin chao " + ps.PersonID + " - " + ps.FullName;
            ViewBag.Thongbao=Result;
            return View();
        }
    }
}



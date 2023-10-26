using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee emp)
        {
            string noti = "Nhan vien: " + emp.EmployeeName + " - " + emp.EmployeeID;
            ViewBag.noti = noti;
            return View();
        }

    } 
}
using Microsoft.AspNetCore.Mvc;
using MyWebsiteMVC.Models;

namespace MyWebsiteMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            var data = new List<EmployeeModel>
            {
                new EmployeeModel("Zovan", "Ayam's kampus"),
                new EmployeeModel("Figur", "Belalang")
            };

            return Json(data);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Name = "{Phạm Minh Đức}";
            ViewData["Age"] = 20;
            return View(model: "CNTT");
        }
    }
}

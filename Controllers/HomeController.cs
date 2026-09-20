using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET MVC");
        }

        public IActionResult About()
        {
            return Content("Tên sinh viên: Phạm Minh Đức");
        }

        public IActionResult Contact()
        {
            return Content("Email sinh viên: BIT240069@st.cmcu.edu.vn");
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return Content("Lỗi: chưa truyền id sản phẩm");
            }
            return Content($"Product ID = {id}");
        }

        public IActionResult Category(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return Content("Lỗi: chưa truyền tên danh mục");
            }
            return Content($"Category = {name}");
        }
    }
}

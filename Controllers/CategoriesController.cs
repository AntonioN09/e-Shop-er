using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    public class CartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

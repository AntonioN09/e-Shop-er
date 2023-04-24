using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

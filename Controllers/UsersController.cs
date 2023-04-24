using Microsoft.AspNetCore.Mvc;

namespace EShop.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

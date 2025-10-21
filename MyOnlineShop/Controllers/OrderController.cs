using Microsoft.AspNetCore.Mvc;

namespace MyOnlineShop.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

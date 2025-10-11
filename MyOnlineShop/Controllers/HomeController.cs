using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

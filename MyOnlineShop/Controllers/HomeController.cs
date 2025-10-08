using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var users = UsersRepository.GetAll();
            return View(users);
        }

        public IActionResult Add(string name)
        {
            UsersRepository.Add(name);
            return RedirectToAction("Index");
        }
    }
}

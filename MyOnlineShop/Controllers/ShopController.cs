using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class ShopController : Controller
    {
        // GET: ShopController
        public ActionResult Index()
        {
            var products = ProductsRepository.GetAll();
            return View(products);
        }

        public ActionResult Add(string name, int price)
        {
            ProductsRepository.Add(name, price);
            return RedirectToAction("Index");
        }

    }
}

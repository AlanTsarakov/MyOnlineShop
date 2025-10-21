using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Interfaces;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class ShopController(IProductsRepository productsRepository) : Controller
    {

        public ActionResult Index()
        {
            var products = productsRepository.GetAll();
            return View(products);
        }

        public ActionResult Add(string name, int price)
        {
            productsRepository.Add(name, price);
            return RedirectToAction("Index");
        }

    }
}

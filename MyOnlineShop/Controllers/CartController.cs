using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Interfaces;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class CartController(ICartsRepository carts, IProductsRepository products) : Controller
    {
        public IActionResult Index()
        {
            var cart = carts.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Add(int productId)
        {
            var product = products.TryGetById(productId);
            if (product != null)
            {
                carts.Add(product, Constants.UserId);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Subtract(int productId)
        {
            var product = products.TryGetById(productId);
            if (product != null)
            {
                carts.Subtract(product, Constants.UserId);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Clear()
        {
            carts.Clear(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}

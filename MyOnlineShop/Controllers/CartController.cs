using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class CartController(CartsRepository carts, ProductsRepository products) : Controller
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
            return RedirectToAction("Index", "Shop");
        }
    }
}

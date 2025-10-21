using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly InMemoryProductsRepository _products;

        public ProductController()
        {
            _products = new InMemoryProductsRepository();
        }

        public ActionResult Index(int id)
        {
            var product = _products.TryGetById(id);
            return View(product);
        }
    }
}

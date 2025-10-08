using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Repositories;

namespace MyOnlineShop.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index(int id)
        {
            var product = ProductsRepository.TryGetById(id);
            return View(product);
        }
    }
}

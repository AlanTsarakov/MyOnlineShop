using Microsoft.AspNetCore.Mvc;
using MyOnlineShop.Interfaces;
using MyOnlineShop.Models;

namespace MyOnlineShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsRepository _cartsRepository;
        private readonly IOrdersRepository _ordersRepository;

        public OrderController(ICartsRepository cartsRepository, IOrdersRepository ordersRepository)
        {
            _cartsRepository = cartsRepository;
            _ordersRepository = ordersRepository;
        }
        public IActionResult Index()
        {
            var cart = _cartsRepository.TryGetByUserId(Constants.UserId);
            return View(cart);
        }

        public IActionResult Buy()
        {
            var cart = _cartsRepository.TryGetByUserId(Constants.UserId);

            if (cart == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var order = new Order { UserId = Constants.UserId, Items = cart.Items};

            _ordersRepository.Add(order);

            _cartsRepository.Clear(Constants.UserId);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
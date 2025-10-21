using MyOnlineShop.Interfaces;
using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public class InMemoryOrdersRepository : IOrdersRepository
    {
        private readonly List<Order> _orders = [];
        public void Add(Order order)
        {
            order.Id = Guid.NewGuid();

            _orders.Add(order);
        }
    }
}

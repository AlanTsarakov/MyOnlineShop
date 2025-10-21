using MyOnlineShop.Models;

namespace MyOnlineShop.Interfaces
{
    public interface IOrdersRepository
    {
        void Add(Order order);
    }
}
using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public interface ICartsRepository
    {
        void Add(Product product, string userId);
        void Clear(string userId);
        void Subtract(Product product, string userId);
        Cart? TryGetByUserId(string userId);
    }
}
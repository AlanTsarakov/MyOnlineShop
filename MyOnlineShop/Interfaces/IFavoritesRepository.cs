using MyOnlineShop.Models;

namespace MyOnlineShop.Interfaces
{
    public interface IFavoritesRepository
    {
        public void Add(Product product, string userId);

        public void Delete(string userId, Product product);

        public Favorite? TryGetByUserId(string userId);

        public void Clear(string userId);
    }
}
using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public interface IProductsRepository
    {
        void Add(string name, int price);
        List<Product> GetAll();
        Product? TryGetById(int id);
    }
}
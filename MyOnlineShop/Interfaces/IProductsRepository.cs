using MyOnlineShop.Models;

namespace MyOnlineShop.Interfaces
{
    public interface IProductsRepository
    {
        void Add(string name, int price);
        List<Product> GetAll();
        Product? TryGetById(int id);
    }
}
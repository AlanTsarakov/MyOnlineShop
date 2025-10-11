using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public class ProductsRepository
    {
        private int _instanceCounter = 0;

        List<Product> products;

        public ProductsRepository()
        {
            products = new List<Product> {
            new Product(++_instanceCounter, "Хлеб", 20),
            new Product(++_instanceCounter, "Масло", 800),
            new Product(++_instanceCounter, "Колбаcа", 200)
            };
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public void Add(string name, int price)
        {
            products.Add(new Product(++_instanceCounter, name, price));
        }

        public Product? TryGetById(int id) 
        {
            try
            {
                return products[id - 1];
            }
            catch
            {
                return null;
            }
        }
    }
}

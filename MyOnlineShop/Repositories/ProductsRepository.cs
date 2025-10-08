using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public static class ProductsRepository
    {
        private static int _instanceCounter = 0;
        static List<Product> products = new List<Product> { new Product(++_instanceCounter, "Хлеб", 20), new Product(++_instanceCounter, "Масло", 800), new Product(++_instanceCounter, "Колбама", 200) };

        public static List<Product> GetAll()
        {
            return products;
        }

        public static void Add(string name, int price)
        {
            products.Add(new Product(++_instanceCounter, name, price));
        }
    }
}

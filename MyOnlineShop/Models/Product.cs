namespace MyOnlineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price {  get; set; }

        public string ?Description { get; set; }

        public string ?Category { get; set; }

        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + Price;
        }

    }
}

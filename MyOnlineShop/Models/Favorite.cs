namespace MyOnlineShop.Models
{
    public class Favorite
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public List<Product> Items { get; set; }

        public decimal TotalCost => Items.Sum(x => x.Price);
    }
}

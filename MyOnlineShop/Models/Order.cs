namespace MyOnlineShop.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }
        public List<CartItem> Items { get; set; }
    }
}

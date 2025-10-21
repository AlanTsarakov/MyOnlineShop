using Microsoft.AspNetCore.Http.Features;

namespace MyOnlineShop.Models
{
    public class Cart
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public List<CartItem> Items { get; set; }

        public decimal TotalCost => Items.Sum(x => x.Price);
    }
}

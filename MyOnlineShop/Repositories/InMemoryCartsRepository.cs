
using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public class InMemoryCartsRepository : ICartsRepository
    {
        private List<Cart> _carts = new List<Cart>();
        public Cart? TryGetByUserId(string userId)
        {
            return _carts?.FirstOrDefault(cart => cart.UserId == userId);
        }

        public void Add(Product product, string userId)
        {
            var cart = TryGetByUserId(userId);

            if (cart == null)
            {
                cart = new Cart()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CartItem>()
                    {
                        new CartItem()
                        {
                            Id = Guid.NewGuid(),
                            Product = product,
                            Quantity = 1
                        }
                    }
                };

                _carts.Add(cart);

            }
            else
            {
                var existingCartItem = cart.Items.FirstOrDefault(item => item.Product.Id == product.Id);
                if (existingCartItem == null)
                {
                    cart.Items.Add(new CartItem() { Id = Guid.NewGuid(), Quantity = 1, Product = product });
                }
                else
                {
                    existingCartItem.Quantity++;
                }
            }
        }

        public void Subtract(Product product, string userId)
        {
            var cart = TryGetByUserId(userId);
            if (cart != null)
            {
                CartItem? cartItem = cart.Items.FirstOrDefault(item => item.Product.Id == product.Id);

                if (cartItem != null)
                {
                    cartItem.Quantity--;

                    if (cartItem.Quantity == 0)
                    {
                        cart.Items.Remove(cartItem);
                    }
                }

            }
        }
        public void Clear(string userId)
        {
            var cart = TryGetByUserId(userId);
            if (cart.Items.Count > 0)
            {
                cart.Items.Clear();
            }
        }
    }
}

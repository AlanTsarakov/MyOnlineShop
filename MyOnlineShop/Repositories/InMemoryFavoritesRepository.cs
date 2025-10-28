using MyOnlineShop.Interfaces;
using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public class InMemoryFavoritesRepository : IFavoritesRepository
    {
        private List<Favorite> _favorites = new List<Favorite>();

        public Favorite? TryGetByUserId(string userId)
        {
            return _favorites.FirstOrDefault(x => x.UserId == userId);
        }
        public void Add(Product product, string userId)
        {
            var favorite = TryGetByUserId(userId);

            if (favorite == null)
            {
                favorite = new Favorite() { Id = Guid.NewGuid(), Items = [product], UserId = userId };
                _favorites.Add(favorite);
            }
            else
            {
                var favoriteItem = favorite.Items.FirstOrDefault(x => x.Id == product.Id);

                if (favoriteItem == null)
                {
                    favorite.Items.Add(product);
                }
            }
        }

        public void Clear(string userId)
        {
            var favorite = TryGetByUserId(userId);
            if (favorite != null && favorite.Items.Count > 0)
            {
                favorite.Items.Clear();
            }
            
        }

        public void Delete(string userId, Product product)
        {
            var favorite = TryGetByUserId(userId);
            favorite.Items?.Remove(product);
        }
    }
}

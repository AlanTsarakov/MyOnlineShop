using MyOnlineShop.Models;

namespace MyOnlineShop.Repositories
{
    public static class UsersRepository
    {
        static List<User> users = new List<User> { new User("Алан"), new User("Батраз"), new User("Ислам")};

        public static List<User> GetAll()
        {
            return users;
        }

        public static void Add(string Name)
        {
            users.Add(new User(Name));
        }
    }
}

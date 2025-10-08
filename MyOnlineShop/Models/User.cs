namespace MyOnlineShop.Models
{
    public class User
    {
        public static int Id { get; private set; } = 0;
        public string Name { get; set; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public User(string name)
        {
            Id++;
            Name = name;
        }
    }
}

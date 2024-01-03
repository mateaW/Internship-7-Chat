namespace ChatApp.Data.Entities.Models
{
    public class User
    {
        public User(string email, string password, string username)
        {
            Email = email;
            Password = password;
            UserName = username;
            IsAdmin = false;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string? UserName { get; set; }

        public bool IsAdmin { get; set; }

        public ICollection<Message> SentMessages { get; set; } = new List<Message>();

        public ICollection<Message> ReceivedMessages { get; set; } = new List<Message>();

        public ICollection<GroupUser> GroupUsers { get; set; } = new List<GroupUser>();

        public ICollection<GroupMessage> GroupMessages { get; set; } = new List<GroupMessage>();
    }
}

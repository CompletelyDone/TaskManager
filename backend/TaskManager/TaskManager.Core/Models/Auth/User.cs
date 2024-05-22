namespace TaskManager.Core.Models.Auth
{
    public class User(Guid id, string email, string hashedPassword)
    {
        public Guid Id { get; set; } = id;
        public string Email { get; set; } = email;
        public string HashedPassword { get; set; } = hashedPassword;
    }
}

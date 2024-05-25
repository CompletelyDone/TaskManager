namespace TaskManager.Core.Auth.Models
{
    public class User(Guid id, string email, string hashedPassword, Role role = Role.Employee)
    {
        public Guid Id { get; set; } = id;
        public string Email { get; set; } = email;
        public string HashedPassword { get; set; } = hashedPassword;
        public Role Role { get; set; } = role;
    }
}

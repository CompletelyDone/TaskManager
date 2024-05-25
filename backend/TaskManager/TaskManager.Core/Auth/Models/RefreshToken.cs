namespace TaskManager.Core.Auth.Models
{
    public class RefreshToken(int id, string token, Guid userId)
    {
        public int Id { get; set; } = id;
        public string Token { get; set; } = token;
        public Guid UserId { get; set; } = userId;
    }
}

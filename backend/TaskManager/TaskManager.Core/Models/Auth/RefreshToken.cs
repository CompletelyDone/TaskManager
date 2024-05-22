namespace TaskManager.Core.Models.Auth
{
    public class RefreshToken(int id, string token, Guid userId)
    {
        public int Id { get; set; } = id;
        public string Token { get; set; } = token;
        public Guid UserId { get; set; } = userId;
    }
}

namespace TaskManager.DataAccess.Auth.Entities
{
    public class RefreshTokenEntity
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public Guid UserId { get; set; }
    }
}

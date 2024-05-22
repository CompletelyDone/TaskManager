using Microsoft.EntityFrameworkCore;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Auth.DBContext
{
    public class AuthDBContext(DbContextOptions<AuthDBContext> options) : DbContext(options)
    {
        public DbSet<UserEntity> Users {  get; set; }
        public DbSet<RefreshTokenEntity> RefreshTokens { get; set; }
    }
}

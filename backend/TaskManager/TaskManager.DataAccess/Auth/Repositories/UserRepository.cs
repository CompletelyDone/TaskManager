using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Auth.Models;
using TaskManager.DataAccess.Auth.DBContext;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Auth.Repositories
{
    public class UserRepository
    {
        private readonly AuthDBContext dbContext;

        public UserRepository(AuthDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Guid> CreateUserAsync(UserEntity user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<List<UserEntity>> GetUsersByRoleAsync(Role role)
        {
            return await dbContext.Users.Where(u => u.Role == role).ToListAsync();
        }
    }
}

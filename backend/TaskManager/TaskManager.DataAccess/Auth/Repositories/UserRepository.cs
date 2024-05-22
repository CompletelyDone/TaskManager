using Microsoft.EntityFrameworkCore;
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

        public async Task CreateUserAsync(UserEntity user)
        {
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}

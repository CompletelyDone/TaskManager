using Microsoft.EntityFrameworkCore;
using TaskManager.DataAccess.Auth.DBContext;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Auth.Repositories
{
    public class RefreshTokenRepository
    {
        private readonly AuthDBContext dBContext;

        public RefreshTokenRepository(AuthDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<RefreshTokenEntity?> GetRefreshTokenByUserIdAsync(Guid id)
        {
            return await dBContext.RefreshTokens.FirstOrDefaultAsync(rf => rf.UserId == id);
        }

        public async Task CreateRefreshTokenAsync(RefreshTokenEntity refreshToken)
        {
            await dBContext.RefreshTokens.AddAsync(refreshToken);
            await dBContext.SaveChangesAsync();
        }

        public async Task UpdateRefreshTokenAsync(RefreshTokenEntity refreshToken)
        {
            dBContext.RefreshTokens.Update(refreshToken);
            await dBContext.SaveChangesAsync();
        }
    }
}

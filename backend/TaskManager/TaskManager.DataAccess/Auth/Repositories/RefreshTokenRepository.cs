using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Auth.Abstractions;
using TaskManager.Core.Auth.Models;
using TaskManager.DataAccess.Auth.DBContext;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Auth.Repositories
{
    public class RefreshTokenRepository : IRepository<RefreshToken, int>
    {
        private readonly AuthDBContext dBContext;
        private readonly IMapper mapper;

        public RefreshTokenRepository(AuthDBContext dBContext, IMapper mapper)
        {
            this.dBContext = dBContext;
            this.mapper = mapper;
        }

        public async Task<RefreshToken?> GetByUserIdAsync(Guid id)
        {
            RefreshTokenEntity? refreshTokenEntity = await dBContext.RefreshTokens.FirstOrDefaultAsync(rf => rf.UserId == id);
            if (refreshTokenEntity == null) return null;
            return mapper.Map<RefreshToken>(refreshTokenEntity);
        }

        public async Task<int> CreateAsync(RefreshToken refreshToken)
        {
            var refreshTokenEntity = mapper.Map<RefreshTokenEntity>(refreshToken);
            await dBContext.RefreshTokens.AddAsync(refreshTokenEntity);
            await dBContext.SaveChangesAsync();
            return refreshTokenEntity.Id;
        }

        public async Task<int> UpdateAsync(RefreshToken refreshToken)
        {
            await dBContext.RefreshTokens
                .Where(x => x.Id == refreshToken.Id)
                .ExecuteUpdateAsync(rt => rt
                    .SetProperty(e => e.Id, refreshToken.Id)
                    .SetProperty(e => e.UserId, refreshToken.UserId)
                    .SetProperty(e => e.Token, refreshToken.Token)
                );

            return refreshToken.Id;
        }

        public async Task<int> DeleteAsync(int id)
        {
            await dBContext.RefreshTokens
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            return id;
        }

        public async Task<RefreshToken?> GetByIdAsync(int id)
        {
            var refreshTokenEntity = await dBContext.RefreshTokens.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (refreshTokenEntity == null) return null;
            return mapper.Map<RefreshToken>(refreshTokenEntity);
        }

        public async Task<IEnumerable<RefreshToken>> GetAllAsync()
        {
            return await dBContext.RefreshTokens.AsNoTracking().ProjectTo<RefreshToken>(mapper.ConfigurationProvider).ToListAsync();
        }
    }
}

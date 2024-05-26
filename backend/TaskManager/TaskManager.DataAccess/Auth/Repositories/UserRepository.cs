using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using TaskManager.Core.Auth.Abstractions;
using TaskManager.Core.Auth.Models;
using TaskManager.DataAccess.Auth.DBContext;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Auth.Repositories
{
    public class UserRepository : IRepository<User, Guid>
    {
        private readonly AuthDBContext dbContext;
        private readonly IMapper mapper;

        public UserRepository(AuthDBContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<Guid> CreateAsync(User user)
        {
            var userEntity = mapper.Map<UserEntity>(user);

            await dbContext.Users.AddAsync(userEntity);
            await dbContext.SaveChangesAsync();

            return user.Id;
        }

        public async Task<Guid> DeleteAsync(Guid id)
        {
            await dbContext.Users
                .Where(u => u.Id == id)
                .ExecuteDeleteAsync();
            return id;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await dbContext.Users.AsNoTracking().ProjectTo<User>(mapper.ConfigurationProvider).ToListAsync();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            UserEntity? userEntity = await dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (userEntity == null) return null;
            return mapper.Map<User>(userEntity);
        }

        public async Task<User?> GetByIdAsync(Guid id)
        {
            var userEntity = await dbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
            if (userEntity == null) return null;
            return mapper.Map<User>(userEntity);
        }

        public async Task<List<User>> GetByRoleAsync(Role role)
        {
            List<UserEntity> userEntity = await dbContext.Users.AsNoTracking().Where(u => u.Role == role).ToListAsync();
            List<User> users = userEntity.Select(e => mapper.Map<User>(e)).ToList();
            return users;
        }

        public async Task<Guid> UpdateAsync(User user)
        {
            await dbContext.Users
                .ExecuteUpdateAsync(ue => ue
                    .SetProperty(u => u.Id, user.Id)
                    .SetProperty(u => u.Email, user.Email)
                    .SetProperty(u => u.HashedPassword, user.HashedPassword)
                    .SetProperty(u => u.Role, user.Role)
                );
            return user.Id;
        }
    }
}

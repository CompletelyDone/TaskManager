using AutoMapper;
using TaskManager.Core.Auth.Models;
using TaskManager.DataAccess.Auth.Entities;

namespace TaskManager.DataAccess.Mapping
{
    public class AuthMapping : Profile
    {
        public AuthMapping()
        {
            CreateMap<User, UserEntity>().ReverseMap();
            CreateMap<RefreshToken, RefreshTokenEntity>().ReverseMap();
        }
    }
}

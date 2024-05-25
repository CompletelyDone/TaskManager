using TaskManager.Core.Utils.Abstractions;

namespace TaskManager.Application.Services
{
    public class AuthService
    {
        private readonly IPasswordHasher passwordHasher;
        private readonly IJwtProvider jwtProvider;

        public AuthService(IPasswordHasher passwordHasher, IJwtProvider jwtProvider)
        {
            this.passwordHasher = passwordHasher;
            this.jwtProvider = jwtProvider;
        }

        public async Task<string> Login(string email, string password)
        {
            var user = "";
            return user;
        }
    }
}

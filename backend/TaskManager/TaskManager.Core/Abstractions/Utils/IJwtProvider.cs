using TaskManager.Core.Models.API;

namespace TaskManager.Core.Abstractions.Utils
{
    public interface IJwtProvider
    {
        string GenerateToken(Employee employee);
    }
}

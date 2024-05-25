using TaskManager.Core.API.Models;

namespace TaskManager.Core.Utils.Abstractions
{
    public interface IJwtProvider
    {
        string GenerateToken(Employee employee);
    }
}

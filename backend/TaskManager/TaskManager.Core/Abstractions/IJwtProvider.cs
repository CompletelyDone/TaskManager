using TaskManager.Core.Models;

namespace TaskManager.Core.Abstractions
{
    public interface IJwtProvider
    {
        string GenerateToken(Employee employee);
    }
}

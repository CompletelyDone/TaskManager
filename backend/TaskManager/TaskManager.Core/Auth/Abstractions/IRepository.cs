namespace TaskManager.Core.Auth.Abstractions
{
    public interface IRepository<T, TId> 
        where TId : struct, IEquatable<TId>, IComparable<TId>
    {
        Task<TId> CreateAsync(T entity);
        Task<T?> GetByIdAsync(TId id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<TId> UpdateAsync(T entity);
        Task<TId> DeleteAsync(TId id);
    }
}

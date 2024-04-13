using System.Linq.Expressions;

namespace SaffronSlice.Core.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetBySpecAsync(ISpecification<TEntity> spec, CancellationToken ct);
    Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec, CancellationToken ct);
    Task<TEntity> GetByIdAsync(object id, CancellationToken ct);
    Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct);
    Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

    Task AddAsync(TEntity entity, CancellationToken ct);
    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct);

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities, CancellationToken ct);

    Task<bool> SaveChangesAsync(CancellationToken ct);
}
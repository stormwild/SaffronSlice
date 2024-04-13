

using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using SaffronSlice.Core.Repositories;

namespace SaffronSlice.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly DbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity, CancellationToken ct)
    {
        await _context.Set<TEntity>().AddAsync(entity, ct);
        await _context.SaveChangesAsync(ct);
    }

    public Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdAsync(object id, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetBySpecAsync(ISpecification<TEntity> spec, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TEntity>> ListAsync(ISpecification<TEntity> spec, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public void Remove(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<TEntity> entities, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveChangesAsync(CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}

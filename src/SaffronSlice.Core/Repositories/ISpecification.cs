using System.Linq.Expressions;

namespace SaffronSlice.Core.Repositories;

public interface ISpecification<TEntity> where TEntity : class
{
    Expression<Func<TEntity, bool>> Criteria { get; }
    List<Expression<Func<TEntity, object>>> Includes { get; }
    List<string> IncludeStrings { get; }
}

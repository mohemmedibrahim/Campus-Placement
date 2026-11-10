using System.Linq.Expressions;
using CampusPlacement.Domain.Common;

namespace CampusPlacement.Application.Interfaces.Repositories;

/// <summary>
/// Generic repository interface for domain entities.
/// </summary>
/// <typeparam name="TEntity">Entity type deriving from BaseEntity.</typeparam>
/// <typeparam name="TId">Primary key type.</typeparam>
public interface IGenericRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    Task<TEntity?> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
    Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<IReadOnlyList<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);
    Task AddAsync(TEntity entity, CancellationToken cancellationToken = default);
    Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    void Update(TEntity entity);
    void Remove(TEntity entity);
}

public interface IGenericRepository<TEntity> : IGenericRepository<TEntity, Guid> where TEntity : BaseEntity<Guid>
{
}

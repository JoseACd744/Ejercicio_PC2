namespace Ejercicio_PC2.Shared.Domain.Repository;

public interface IBaseRepository<TEntity>
{
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(int id);
    Task<TEntity> SaveAsync(TEntity entity);
    Task<IEnumerable<TEntity>> ListAsync();
    Task<TEntity> FindByIdAsync(int id);
}
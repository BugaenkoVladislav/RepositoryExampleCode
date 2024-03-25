using System.Linq.Expressions;

namespace TestRepository.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity> GetEntityFromExpression(Expression<Func<TEntity,bool>> expression);
    Task<List<TEntity>> GetAllEntitiesFromExpression(Expression<Func<TEntity,bool>> expression);
    Task<List<TEntity>> GetAllEntities();
    Task UpdateEntityFromExpression(TEntity newEntity);
    Task CreateEntity(TEntity newEntity);
    Task RemoveEntityFromExpression(Expression<Func<TEntity,bool>> expression);
}
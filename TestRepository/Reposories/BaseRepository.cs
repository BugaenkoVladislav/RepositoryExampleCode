using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TestRepository.Interfaces;

namespace TestRepository.Reposories;

public class BaseRepository<TEntity>(DbContext db):IRepository<TEntity> where TEntity : class
{
    private DbContext _db = db;  
    public virtual async Task<List<TEntity>> GetAllEntitiesFromExpression(Expression<Func<TEntity, bool>> expression)
    {
        return await _db.Set<TEntity>().Where(expression).ToListAsync();
    }

    public virtual  async Task<TEntity> GetEntityFromExpression(Expression<Func<TEntity, bool>> expression)
    {
        return await _db.Set<TEntity>().FirstAsync(expression);
    }

    public virtual async Task<List<TEntity>> GetAllEntities()
    {
        return await _db.Set<TEntity>().ToListAsync();
    }

    public virtual async Task UpdateEntityFromExpression(TEntity entity)
    {
        _db.Set<TEntity>().Update(entity);
        await _db.SaveChangesAsync();
    }

    public virtual  async Task CreateEntity(TEntity newEntity)
    {
        await _db.Set<TEntity>().AddAsync(newEntity);
        await _db.SaveChangesAsync();
    }

    public virtual async Task RemoveEntityFromExpression(Expression<Func<TEntity, bool>> expression)
    {
        var entity = await GetEntityFromExpression(expression);
        db.Set<TEntity>().Remove(entity);
        await db.SaveChangesAsync();
    }
}
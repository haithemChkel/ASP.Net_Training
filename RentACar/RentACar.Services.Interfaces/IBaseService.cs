using System.Collections.Generic;

namespace RentACar.Services.Interfaces
{
    public interface IBaseService<TEntity, TKey>
    {
        TEntity GetById(TKey id);
        IEnumerable<TEntity> GetAll();
        TEntity Insert(TEntity entity);
        TEntity Update(TKey id, TEntity entity);
        bool Delete(TKey id);
    }
}

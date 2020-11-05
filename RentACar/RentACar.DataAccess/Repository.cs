using PetaPoco;
using RentACar.DataAccess.Interfaces;
using System.Collections.Generic;

namespace RentACar.DataAccess
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
    {
        private IDatabase _db;

        public Repository(IDatabase db)
        {
            _db = db;
        }

        public IEnumerable<TEntity> GetAll()
        {
           return _db.Query<TEntity>();
        }

        public TEntity GetById(TKey id)
        {
            return _db.Single<TEntity>(id);
        }

        public TEntity Insert(TEntity entity)
        {
            return (TEntity)_db.Insert(entity);
        }

        public TEntity Update(TKey id, TEntity entity)
        {
            if (_db.Update(entity, id) > 0)
            {
                return entity;
            }
            throw new System.Exception($"Entity cannot be updated with Id = {id}");
        }

        public bool Delete(TKey id)
        {
            var entity = this.GetById(id);
            if (entity == null)
            {
                throw new System.Exception($"User not found with Id = {id}");
            }
            return _db.Delete<TEntity>(entity) > 0;
        }
    }
}

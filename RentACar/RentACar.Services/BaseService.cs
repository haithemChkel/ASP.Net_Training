using RentACar.DataAccess.Interfaces;
using RentACar.Services.Interfaces;
using System.Collections.Generic;

namespace RentACar.Services
{
    public class BaseService<TEntity, TKey> : IBaseService<TEntity, TKey>
    {
        protected IRepository<TEntity, TKey> _repository;

        public BaseService(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }

        public bool Delete(TKey id)
        {
           return _repository.Delete(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(TKey id)
        {
            return _repository.GetById(id);
        }

        public TEntity Insert(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public TEntity Update(TKey id, TEntity entity)
        {
            return _repository.Update(id, entity);
        }
    }
}

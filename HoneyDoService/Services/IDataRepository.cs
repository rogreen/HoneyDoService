using HoneyDoService.Models;
using System.Collections.Generic;

namespace HoneyDoService.Services
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(HoneyDoItem honeyDoItem, TEntity entity);
        void Delete(HoneyDoItem honeyDoItem);
    }
}

using Core.Data.Model.Infrastructure;

namespace Core.Data.Infrastructure
{
    public interface IInsertableRepository<T> :
      IRepository<T> where T : class, IEntity
    {
        T Insert(T item);
    }
}

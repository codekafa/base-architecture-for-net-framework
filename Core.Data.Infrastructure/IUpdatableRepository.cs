using Core.Data.Model.Infrastructure;

namespace Core.Data.Infrastructure
{
    public interface IUpdatableRepository<T> :
      IRepository<T> where T : class, IEntity
    {
        T Update(T item);
    }
}

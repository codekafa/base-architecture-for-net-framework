
using Core.Data.Model.Infrastructure;

namespace Core.Data.Infrastructure
{
    public interface IDeletableRepository<T> :
     IRepository<T> where T : class, IEntity
    {
        void Delete(T item);
    }
}

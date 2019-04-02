using Core.Data.Model.Infrastructure;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface IUpdatableRepository<T> :
      IRepository<T> where T : class, IEntity
    {
        T Update(T t, object key);
        Task<T> UpdateAsyn(T t, object key);
    }
}

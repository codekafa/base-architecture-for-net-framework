using Core.Data.Model.Infrastructure;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface IInsertableRepository<T> :
      IRepository<T> where T : class, IEntity
    {
        T Add(T t);
        Task<T> AddAsyn(T t);
    }
}

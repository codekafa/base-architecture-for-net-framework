
using Core.Data.Model.Infrastructure;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface IDeletableRepository<T> :
     IRepository<T> where T : class, IEntity
    {
        void Delete(T entity);
        Task<int> DeleteAsyn(T entity);
    }
}

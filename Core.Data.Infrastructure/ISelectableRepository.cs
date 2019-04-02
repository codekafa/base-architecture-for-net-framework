using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface ISelectableRepository<T> :
        IRepository<T> where T : class, IEntity
    {
        int Count();

        T Get(int id);

        Task<T> GetAsync(int id);
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
    }
}

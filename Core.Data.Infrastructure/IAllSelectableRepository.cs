using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{

    public interface IAllSelectableRepository<T> :
       IRepository<T> where T : class, IEntity
    {
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsyn();
    }
}

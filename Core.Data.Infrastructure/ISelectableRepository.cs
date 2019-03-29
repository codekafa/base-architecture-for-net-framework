using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface ISelectableRepository<T> :
        IRepository<T> where T : class, IEntity
    {
        List<T> GetBy(string query, object paramteres);
        List<T> GetByStoredProcedure(string query, object param = null);

      
    }
}

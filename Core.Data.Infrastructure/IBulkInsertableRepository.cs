using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Infrastructure
{
    public interface IBulkInsertableRepository<T> :
      IRepository<T> where T : class, IEntity
    {
        void BulkInsert(List<T> items);
    }
}

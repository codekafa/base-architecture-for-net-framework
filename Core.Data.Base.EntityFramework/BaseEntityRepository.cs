using Core.Data.Infrastructure;
using Core.Data.Model.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Base.EntityFramework
{
    public abstract class BaseEntityRepository<OC, T>
        : ISelectableRepository<T>,
        IAllSelectableRepository<T>,
        IInsertableRepository<T>,
        IDeletableRepository<T>,
        IUpdatableRepository<T>,
         IExecutableRepository<T>
        where T : class, IEntity where OC : BaseDataContext, new()
    {
        public OC _context;
        public BaseEntityRepository()
        {
            _context = new OC();
        }

        public void Delete(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public bool ExecuteQuery(string query, object param = null)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public List<T> GetBy(string query, object parameters)
        {
            return _context.Database.SqlQuery<T>(query, parameters as SqlParameter[]).ToList();
        }

        public List<T> GetByStoredProcedure(string query, object param = null)
        {
            throw new NotImplementedException();
        }

        public T Insert(T item)
        {
            return _context.Set<T>().Add(item);
        }

        public T Update(T item)
        {
            _context.Entry<T>(item).State = System.Data.Entity.EntityState.Modified;
            _context.Set<T>().Attach(item);
            return item;
        }

    }
}

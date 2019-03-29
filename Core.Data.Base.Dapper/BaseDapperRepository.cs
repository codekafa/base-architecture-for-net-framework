
using Core.Data.Infrastructure;
using Core.Data.Model.Infrastructure;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Core.Data.Base.Dapper
{
    public abstract class BaseDapperRepository<DCON, T> :
        IBulkInsertableRepository<T>,
        IAllSelectableRepository<T>,
        ISelectableRepository<T>,
        IInsertableRepository<T>,
        IDeletableRepository<T>,
        IUpdatableRepository<T>,
        IExecutableRepository<T>
        where T : class, IEntity where DCON : BaseDataBaseConnection, new()
    {
        private BaseDataBaseConnection _context;

        public BaseDapperRepository()
        {
            _context = new DCON();
        }

        public void BulkInsert(List<T> items)
        {
            using (var connection = _context.GetConnection)
            {
                connection.Open();
                connection.Insert(items);
            }
        }

        public void Delete(T item)
        {
            using (var connection = _context.GetConnection)
            {
                connection.Open();
                var identity = connection.Delete(item);
            }
        }

        public List<T> GetBy(string query,object parameters)
        {
            using (var connection = _context.GetConnection)
            {
                var list = connection.Query<T>(query,parameters).ToList();
                return list;
            }
        }

        public List<T> GetAll()
        {
            using (var connection = _context.GetConnection)
            {
                var list = connection.GetAll<T>().ToList();
                return list;
            }
        }
        public bool ExecuteQuery(string query, object param = null)
        {
                using (var connection = _context.GetConnection)
                {
                connection.Execute(query, param);
                return true;
                }
        }

        public List<T> GetByStoredProcedure(string query, object param = null)
        {
            using (var connection = _context.GetConnection)
            {
                var result = connection.Query<T>(query, param, null, true, null, CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public T Update(T item)
        {
            using (var connection = _context.GetConnection)
            {
                connection.Open();
                var identity = connection.Update(item);
                return item;
            }
        }

        public T Insert(T item)
        {
            using (var connection = _context.GetConnection)
            {
                connection.Open();
                var identity = connection.Insert(item);
                typeof(T).GetProperty("ID").SetValue(item, identity);
                return item;
            }
        }

    }
}

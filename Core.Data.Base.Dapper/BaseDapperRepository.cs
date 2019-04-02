
using Core.Data.Infrastructure;
using Core.Data.Model.Infrastructure;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public T Add(T t)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> AddAsyn(T t)
        {
            throw new System.NotImplementedException();
        }

        public void BulkInsert(List<T> items)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> DeleteAsyn(T entity)
        {
            throw new System.NotImplementedException();
        }

        public bool ExecuteQuery(string query, object param = null)
        {
            throw new System.NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<T>> FindByAsyn(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ICollection<T>> GetAllAsyn()
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(T t, object key)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> UpdateAsyn(T t, object key)
        {
            throw new System.NotImplementedException();
        }
    }
}

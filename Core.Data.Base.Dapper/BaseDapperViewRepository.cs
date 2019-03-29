using Core.Data.Infrastructure;
using Core.Data.Model.Infrastructure;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Base.Dapper
{
    public abstract class BaseDapperViewRepository<DCON, T> :
        ISelectableRepository<T>
        where T : class, IViewModel where DCON : BaseDataBaseConnection, new()
    {

        private BaseDataBaseConnection _context;

        public BaseDapperViewRepository()
        {
            _context = new DCON();
        }

        public List<T> GetBy(string query, object parameters)
        {
            using (var connection = _context.GetConnection)
            {
                var list = connection.Query<T>(query, parameters).ToList();
                return list;
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
    }
}

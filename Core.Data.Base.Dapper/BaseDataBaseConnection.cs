using Core.Data.DBConnections.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Base.Dapper
{
    public abstract class BaseDataBaseConnection : IConnectionFactory
    {
        public abstract IDbConnection GetConnection { get;  set; }


        public abstract string ConnectionString { get; set; }

        public BaseDataBaseConnection()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

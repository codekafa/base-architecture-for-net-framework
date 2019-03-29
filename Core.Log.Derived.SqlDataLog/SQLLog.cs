using Core.Data.DBConnections.Infrastructure;
using Core.Log.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Log.Derived.SqlDataLog
{
    public abstract class SQLLog : ILogSync, ILogAsync
    {
        public IConnectionFactory _connection { get; private set; }
        public SQLLog(IConnectionFactory con)
        {
            _connection = con;
        }

        public abstract void DoLog(ILogData data);

        public abstract Task DoLogAsync(ILogData data);
    }
}

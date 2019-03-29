using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.DBConnections.Infrastructure
{
    public interface IConnectionFactory : IDisposable
    {
       IDbConnection GetConnection { get; }

        string ConnectionString { get; }
    }
}

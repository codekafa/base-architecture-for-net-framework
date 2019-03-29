using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Log.Infrastructure
{
    public interface ILog
    { }

    public interface ILogSync : ILog
    {
        void DoLog(ILogData data);
    }

    public interface ILogAsync : ILog
    {
        Task DoLogAsync(ILogData data);
    }
}

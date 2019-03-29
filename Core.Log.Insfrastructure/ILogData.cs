using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Log.Infrastructure
{
    public interface ILogData
    {
        DateTime LogDate { get; set; }
        string LogData { get; set; }
    }
}

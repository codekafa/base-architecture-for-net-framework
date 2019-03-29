using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExceptionHandling.Data.Infrastructure
{
    public abstract class BaseException : Exception
    {
        public BaseException(string message)
            :base(message)
        {

        }

        public BaseException(string message, Exception innerException)
            :base(message, innerException)
        {

        }
    }
}

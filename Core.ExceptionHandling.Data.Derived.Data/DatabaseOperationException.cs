using Core.ExceptionHandling.Data.Infrastructure;
using Core.ExceptionHandling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExceptionHandling.Data.Derived.Data
{
    public class DatabaseOperationException : BaseException, IDataException
    {
        public DatabaseOperationExceptionModel DataOperationExceptionModel { get; private set; }

        public DatabaseOperationException(DatabaseOperationExceptionModel model) :
            base(model.OriginalExceptionMessage)
        {
            DataOperationExceptionModel = model;
        }

        public DatabaseOperationException(DatabaseOperationExceptionModel model, Exception innerException)
            : base(model.OriginalExceptionMessage, innerException)
        {
            DataOperationExceptionModel = model;
        }
    }
}

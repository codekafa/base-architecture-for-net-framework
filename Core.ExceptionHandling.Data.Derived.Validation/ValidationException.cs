using Core.ExceptionHandling.Data.Infrastructure;
using Core.ExceptionHandling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ExceptionHandling.Data.Derived.Validation
{
    public class ValidationException : BaseException, IValidationException
    {
        public ValidationExceptionModel ValidationExceptionModel { get; private set; }
        public ValidationException(ValidationExceptionModel model) :
            base(model.OriginalMessage)
        {
            ValidationExceptionModel = model;
        }

        public ValidationException
            (ValidationExceptionModel model, Exception innerException)
            : base(model.OriginalMessage, innerException)
        {
            ValidationExceptionModel = model;
        }
    }
}

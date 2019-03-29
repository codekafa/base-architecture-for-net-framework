using Core.ExceptionHandling.Data.Infrastructure;
using Core.ExceptionHandling.Model;
using System;

namespace Core.ExceptionHandling.Data.Derived.Business
{
    public class BusinessOperationException
        : BaseException, IBusinessException
    {
        public BusinesOperationExceptionModel BusinessOperationExceptionModel
        { get; private set; }

        public BusinessOperationException
            (BusinesOperationExceptionModel model) : base(model.OriginalMessage)
        {
            BusinessOperationExceptionModel = model;
        }

        public BusinessOperationException
            (BusinesOperationExceptionModel model, Exception innerException)
            : base(model.OriginalMessage, innerException)
        {
            BusinessOperationExceptionModel = model;
        }
    }
}

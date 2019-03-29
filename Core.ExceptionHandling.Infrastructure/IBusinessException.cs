using Core.ExceptionHandling.Model;

namespace Core.ExceptionHandling.Data.Infrastructure
{
    public interface IBusinessException
    {
        BusinesOperationExceptionModel BusinessOperationExceptionModel { get; }
    }
}

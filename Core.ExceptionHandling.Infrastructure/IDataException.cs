using Core.ExceptionHandling.Model;

namespace Core.ExceptionHandling.Data.Infrastructure
{
    public interface IDataException 
    {
        DatabaseOperationExceptionModel DataOperationExceptionModel { get; }
    }
}

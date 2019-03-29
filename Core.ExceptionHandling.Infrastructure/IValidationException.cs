using Core.ExceptionHandling.Model;

namespace Core.ExceptionHandling.Data.Infrastructure
{
    public interface IValidationException
    {
        ValidationExceptionModel ValidationExceptionModel { get; }
    }
}



using System.Collections.Generic;

namespace Core.ExceptionHandling.Model
{
    public class ValidationExceptionModel
    {
        public string ModelName { get; set; }
        public List<string> ValidationMessages { get; set; }
        public string OriginalMessage { get; set; }
    }
}
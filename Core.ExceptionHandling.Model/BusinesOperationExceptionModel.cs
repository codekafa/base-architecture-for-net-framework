namespace Core.ExceptionHandling.Model
{
    public class BusinesOperationExceptionModel
    {
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public string OriginalMessage { get; set; }
    }
}
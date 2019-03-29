namespace Core.ExceptionHandling.Model
{
    public class DatabaseOperationExceptionModel
    {
        public string DatabaseName { get; set; }
        public string DataSourceName { get; set; }
        public string OriginalExceptionMessage { get; set; }
    }
}
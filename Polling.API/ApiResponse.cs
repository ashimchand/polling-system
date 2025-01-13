namespace Polling.API
{
    public class ApiResponse<T>
    {
        public T? Data { get; }
        public string Message { get; }
        public bool Success { get; }

        public ApiResponse(T? data, string message = "Request successful", bool success = true)
        {
            Data = data;
            Message = message;
            Success = success;
        }
    }
}

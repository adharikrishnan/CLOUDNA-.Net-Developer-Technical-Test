namespace CloudNA.API.Models;

public class Result<T>
{
    public T? Data { get; set; }
    
    public bool Success { get; set; }
    
    public string? ErrorMessage { get; set; }

    public Result(T data)
    {
        Data = data;
        Success = true;
    }

    public Result(string errorMessage)
    {
        ErrorMessage = errorMessage;
        Success = false;
    }
}
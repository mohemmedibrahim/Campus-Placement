namespace CampusPlacement.Application.DTOs.Common;

/// <summary>
/// Standard unified API response wrapper.
/// </summary>
/// <typeparam name="T">Type of payload data.</typeparam>
public class ApiResponse<T>
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T? Data { get; set; }
    public List<string>? Errors { get; set; }

    public static ApiResponse<T> SuccessResponse(T data, string message = "Request processed successfully.")
    {
        return new ApiResponse<T>
        {
            Success = true,
            Message = message,
            Data = data,
            Errors = null
        };
    }

    public static ApiResponse<T> FailureResponse(string message, List<string>? errors = null)
    {
        return new ApiResponse<T>
        {
            Success = false,
            Message = message,
            Data = default,
            Errors = errors ?? new List<string>()
        };
    }
}

/// <summary>
/// Non-generic standard API response.
/// </summary>
public class ApiResponse : ApiResponse<object>
{
    public static ApiResponse SuccessResult(string message = "Request processed successfully.")
    {
        return new ApiResponse
        {
            Success = true,
            Message = message,
            Data = null,
            Errors = null
        };
    }

    public static ApiResponse FailureResult(string message, List<string>? errors = null)
    {
        return new ApiResponse
        {
            Success = false,
            Message = message,
            Data = null,
            Errors = errors ?? new List<string>()
        };
    }
}

namespace OpenSky.Core.Response;

/// <summary>
/// Represents the result of an operation, containing the response, success status, and error information.
/// </summary>
/// <typeparam name="T">The type of the response.</typeparam>
public sealed class Result<T>
{
    /// <summary>
    /// Gets the response of the operation.
    /// </summary>
    public T? Response { get; }

    /// <summary>
    /// Gets a value indicating whether the operation was successful.
    /// </summary>
    public bool IsSuccess { get; }

    /// <summary>
    /// Gets the error information if the operation failed.
    /// </summary>
    public Error? Error { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{T}"/> class.
    /// </summary>
    /// <param name="response">The response of the operation.</param>
    /// <param name="isSuccess">A value indicating whether the operation was successful.</param>
    /// <param name="error">The error information if the operation failed.</param>
    private Result(T? response, bool isSuccess, Error? error)
    {
        Response = response;
        IsSuccess = isSuccess;
        Error = error;
    }

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    /// <param name="response">The response of the operation.</param>
    /// <returns>A successful result containing the response.</returns>
    public static Result<T> Success(T response) => new(response, true, null);

    /// <summary>
    /// Creates a failed result.
    /// </summary>
    /// <param name="error">The error information.</param>
    /// <returns>A failed result containing the error information.</returns>
    public static Result<T> Failure(Error error) => new(default, false, error);
}
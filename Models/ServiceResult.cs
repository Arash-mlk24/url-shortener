namespace UrlShortener.Models;

public class ServiceResult<T>
{

  public bool HasError { get; set; }

  public string ErrorMessage { get; set; }

  public T? Result { get; set; }

  private ServiceResult(bool hasError, string errorMessage, T? result)
  {
    this.HasError = hasError;
    ErrorMessage = errorMessage;
    Result = result;
  }

  public static ServiceResult<T> SetResult(T result)
  {
    return new ServiceResult<T>(
      false,
      "",
      result
    );
  }

  public static ServiceResult<T> SetError(string errorMessage)
  {
    return new ServiceResult<T>(
      true,
      errorMessage,
      default(T)
    );
  }

}

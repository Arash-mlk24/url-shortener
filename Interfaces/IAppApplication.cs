using UrlShortener.Models;

namespace UrlShortener.Interfaces;

public interface IAppApplication
{
  ServiceResult<string> getFullPath(string id);
}

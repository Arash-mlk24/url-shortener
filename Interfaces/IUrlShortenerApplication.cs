using UrlShortener.Models;

namespace UrlShortener.Interfaces
{
  public interface IUrlShortenerApplication
  {
    ServiceResult<string> getShortenedUrl(GetUrlBody body);
  }
}
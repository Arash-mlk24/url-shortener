namespace UrlShortener.Services;

using UrlShortener.Interfaces;

public class UrlShortenerService : IUrlShortenerService
{

  public UrlShortenerService()
  {

  }

  public string getShortenedUrl(string FullPath)
  {
    return $"{FullPath} => goo.gle";
  }

}

namespace UrlShortener.Services;

using UrlShortener.Interfaces;

public class UrlShortenerService : IUrlShortenerService
{

  public UrlShortenerService() { }

  public string getUrl(string FullPath)
  {
    return $"{FullPath} => goo.gle";
  }

}

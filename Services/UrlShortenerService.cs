namespace UrlShortener.Services;

using UrlShortener.Interfaces;
using UrlShortener.Infrastructure.DB;

public class UrlShortenerService : IUrlShortenerService
{
  private UrlShortenerContext urlShortenerContext;
  public UrlShortenerService(UrlShortenerContext urlShortenerContext)
  {
    this.urlShortenerContext = urlShortenerContext;
  }
  public string getShortenedUrl(string FullPath)
  {
    // var query = urlShortenerContext.UrlItems  
    //   .Where(url => url.);
    return "string";
  }
}

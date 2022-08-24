namespace UrlShortener.Services;

using UrlShortener.Interfaces;
using UrlShortener.Infrastructure.DB;
using UrlShortener.Entities;

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

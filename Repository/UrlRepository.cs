namespace UrlShortener.Services;

using UrlShortener.Interfaces;
using UrlShortener.Infrastructure.DB;

public class UrlRepository : IUrlRepository
{
  private UrlShortenerContext urlShortenerContext;
  public UrlRepository(UrlShortenerContext urlShortenerContext)
  {
    this.urlShortenerContext = urlShortenerContext;
  }
  public string GetByFullPath(string fullPath)
  {

    var query = urlShortenerContext.UrlItems
      .Where(url => url.FullPath == fullPath)
      .FirstOrDefault();

    if (query == null)
    {
      return "nulllllll";
    }
    else
    {
      return "not null!";
    }

  }
}

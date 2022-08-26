namespace UrlShortener.Services;

using UrlShortener.Interfaces;
using UrlShortener.Infrastructure.DB;
using UrlShortener.Entities;

public class UrlRepository : IUrlRepository
{
  private UrlShortenerContext urlShortenerContext;
  public UrlRepository(UrlShortenerContext urlShortenerContext)
  {
    this.urlShortenerContext = urlShortenerContext;
  }
  public Url? GetByFullPath(string fullPath)
  {

    var query = urlShortenerContext.UrlItems
      .Where(url => url.FullPath == fullPath)
      .FirstOrDefault();

    return query;

  }
}

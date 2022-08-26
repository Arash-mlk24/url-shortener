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

    Url url = new Url();
    url.ID = new Guid().ToString();
    url.FullPath = fullPath;

    var query = urlShortenerContext.UrlItems
        .Add(url);

    urlShortenerContext.SaveChanges();

    return url;

  }
}

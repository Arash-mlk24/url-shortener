using UrlShortener.Interfaces;
using UrlShortener.Infrastructure.DB;
using UrlShortener.Entities;

namespace UrlShortener.Services;

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

    Guid g = Guid.NewGuid();
    string GuidString = Convert.ToBase64String(g.ToByteArray());
    GuidString = GuidString.Replace("=", "");
    GuidString = GuidString.Replace("+", "");
    GuidString = GuidString.Replace("/", "");

    url.ID = GuidString;
    url.FullPath = fullPath;

    var query = urlShortenerContext.UrlItems
        .Add(url);
    urlShortenerContext.SaveChanges();

    return url;

  }
  public Url? GetById(string id)
  {

    var query = urlShortenerContext.UrlItems
        .Find(id);
    return query;

  }

}

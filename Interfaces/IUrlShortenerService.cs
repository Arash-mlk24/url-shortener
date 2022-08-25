namespace UrlShortener.Interfaces;

public interface IUrlRepository
{
  string getShortenedUrl(string FullPath);
}

namespace UrlShortener.Interfaces;

public interface IUrlShortenerService
{
  string getShortenedUrl(string FullPath);
}

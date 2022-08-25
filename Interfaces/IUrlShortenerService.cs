namespace UrlShortener.Interfaces;

public interface IUrlRepository
{
  string GetByFullPath(string FullPath);
}

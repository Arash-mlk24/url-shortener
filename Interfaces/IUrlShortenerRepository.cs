using UrlShortener.Entities;

namespace UrlShortener.Interfaces;

public interface IUrlRepository
{
  UrlEntity? GetByFullPath(string fullPath);
}

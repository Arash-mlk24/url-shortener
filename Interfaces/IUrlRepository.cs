using UrlShortener.Entities;

namespace UrlShortener.Interfaces;

public interface IUrlRepository
{
  Url? GetByFullPath(string fullPath);
  Url? GetById(string id);
}
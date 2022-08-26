using UrlShortener.Entities;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Applications
{
  class UrlShortenerApplication : IUrlShortenerApplication
  {

    IUrlRepository urlRepository;

    public UrlShortenerApplication(IUrlRepository urlRepository)
    {
      this.urlRepository = urlRepository;
    }

    public ServiceResult<string> getShortenedUrl(GetUrlBody body)
    {
      try
      {
        Url? serviceResult = urlRepository.GetByFullPath(body.FullUrlPath);
        return ServiceResult<string>.SetResult(serviceResult == null ? "nullll" : serviceResult.ID);
      }
      catch (Exception exception)
      {
        return ServiceResult<string>.SetError("System Error");
      }
    }
  }
}
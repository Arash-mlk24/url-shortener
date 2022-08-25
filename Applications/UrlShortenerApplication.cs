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
        string serviceResult = urlRepository.GetByFullPath(body.FullUrlPath);
        return ServiceResult<string>.SetResult(serviceResult);
      }
      catch (Exception error)
      {
        return ServiceResult<string>.SetError("System Error");
      }
    }
  }
}
using UrlShortener.Entities;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Applications;

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
      if (serviceResult == null) throw new Exception();
      return ServiceResult<string>.SetResult("https://localhost:7154/" + serviceResult.ID);
    }
    catch (Exception exception)
    {
      return ServiceResult<string>.SetError("System Error");
    }
  }

}

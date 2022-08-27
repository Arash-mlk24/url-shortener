using UrlShortener.Entities;
using UrlShortener.Interfaces;
using UrlShortener.Models;

namespace UrlShortener.Applications;

class AppApplication : IAppApplication
{

  IUrlRepository urlRepository;

  public AppApplication(IUrlRepository urlRepository)
  {
    this.urlRepository = urlRepository;
  }

  public ServiceResult<string> getFullPath(string id)
  {
    try
    {
      Url? serviceResult = urlRepository.GetById(id);
      if (serviceResult == null) throw new Exception();
      return ServiceResult<string>.SetResult(serviceResult.FullPath);
    }
    catch (Exception exception)
    {
      return ServiceResult<string>.SetError("System Error");
    }
  }

}

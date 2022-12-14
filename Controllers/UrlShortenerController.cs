using UrlShortener.Models;
using UrlShortener.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlShortenerController : ControllerBase
{

  private readonly ILogger<UrlShortenerController> _logger;
  private IUrlShortenerService _service;

  public UrlShortenerController(ILogger<UrlShortenerController> logger, IUrlShortenerService service)
  {
    _logger = logger;
    _service = service;
  }

  [HttpPost("GetShortenedUrl")]
  public ServiceResult<string> GetUrl(GetUrlBody body)
  {
    try
    {
      string serviceResult = _service.getUrl(body.FullUrlPath);
      return ServiceResult<string>.SetResult(serviceResult);
    }
    catch (Exception error)
    {
      return ServiceResult<string>.SetError("System Error");
    }
  }

}

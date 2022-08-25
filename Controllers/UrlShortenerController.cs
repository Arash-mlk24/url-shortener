using UrlShortener.Models;
using UrlShortener.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers;

[ApiController]
[Route("[controller]")]
public class UrlShortenerController : ControllerBase
{

  private readonly ILogger<UrlShortenerController> _logger;
  private IUrlShortenerApplication urlShortenerApplication;

  public UrlShortenerController(ILogger<UrlShortenerController> logger, IUrlShortenerApplication urlShortenerApplication)
  {
    _logger = logger;
    this.urlShortenerApplication = urlShortenerApplication;
  }

  [HttpPost("GetShortenedUrl")]
  public ServiceResult<string> GetUrl(GetUrlBody body)
  {
    return urlShortenerApplication.getShortenedUrl(body);
  }

}

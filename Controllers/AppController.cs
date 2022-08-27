using UrlShortener.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UrlShortener.Controllers;

[ApiController]
[Route("/")]
public class AppController : ControllerBase
{

  private IAppApplication appApplication;

  public AppController(IAppApplication appApplication)
  {
    this.appApplication = appApplication;
  }

  [HttpGet("{id}")]
  public void GetFullPath(string id)
  {
    var result = appApplication.getFullPath(id);
    if (result.HasError)
    {
      Response.Redirect("https://google.com", true);
    }
    else
    {
      string redirectingUrl;
      if (result.Result == null)
      {
        redirectingUrl = "https://google.com";
      }
      else
      {
        redirectingUrl = result.Result.StartsWith("http://") || result.Result.StartsWith("https://") ? result.Result : "https://" + result.Result;
      }
      Response.Redirect(redirectingUrl, true);
    }
  }

}

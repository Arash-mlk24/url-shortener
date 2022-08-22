namespace UrlShortener.Models;

public class GetUrlBody
{

  public string FullUrlPath { get; set; }

  public GetUrlBody(string FullUrlPath)
  {
    this.FullUrlPath = FullUrlPath;
  }

}

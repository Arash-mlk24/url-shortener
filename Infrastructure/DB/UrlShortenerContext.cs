using UrlShortener.Entities;
using Microsoft.EntityFrameworkCore;

namespace UrlShortener.Infrastructure.DB;

public class UrlShortenerContext : DbContext
{
  public DbSet<Url> UrlItems { get; set; } = null!;
  public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options) { }
}

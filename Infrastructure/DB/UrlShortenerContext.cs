namespace UrlShortener.Infrastructure.DB;

using UrlShortener.Entities;
using Microsoft.EntityFrameworkCore;

public class UrlShortenerContext : DbContext
{
  public DbSet<UrlEntity> UrlItems { get; set; } = null!;
  public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options) { }
}

namespace UrlShortener.Infrastructure.DB;

using UrlShortener.Entities;
using Microsoft.EntityFrameworkCore;

public class UrlShortenerContext : DbContext
{
  public DbSet<UrlEntity> UrlItems { get; set; } = null!;
  public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options) { }
  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {

    // modelBuilder.Entity<UrlEntity>()
    //     .HasKey(x => x.ID)
    modelBuilder.Entity<UrlEntity>(entity =>
      {

        entity.HasKey(x => x.ID);

      });

  }
}

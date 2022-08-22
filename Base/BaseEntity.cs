namespace UrlShortener.Base;

public abstract class BaseEntity
{
  public virtual long Id { get; protected set; }
  protected BaseEntity() { }
  protected BaseEntity(long id)
  {
    Id = id;
  }
}

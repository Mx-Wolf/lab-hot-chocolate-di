using Microsoft.AspNetCore.Mvc;

namespace Aweton.Mxw.Endpoint.Web;

[ExtendObjectType(KnownConstants.QueryName)]
public class Flavor
{
  public Task<IQueryable<string>> GetFlavorNames([FromServices] IFlavorService resolver)
    => resolver.GetNames();
}
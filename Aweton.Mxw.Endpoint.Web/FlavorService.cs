namespace Aweton.Mxw.Endpoint.Web;

public class FlavorService :IFlavorService
{
  private static readonly string[] sourceArray = [
      "Milk Chocolate",
    "Dark Chocolate",
    "White Chocolate"
    ];

  public Task<IQueryable<string>> GetNames()
    => Task.FromResult(sourceArray.AsQueryable());
}
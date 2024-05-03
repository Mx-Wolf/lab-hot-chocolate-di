namespace Aweton.Mxw.Endpoint.Web;

public interface IFlavorService
{
  Task<IQueryable<string>> GetNames();
}
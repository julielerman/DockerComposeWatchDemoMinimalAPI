
public static class ValueEndpoints
{
  public static void MapValueEndpoints(this IEndpointRouteBuilder routes)
  {

    routes.MapGet("/values", () =>
{
  return new string[] { "value1", "value2", "value3" };
}).WithOpenApi();

  }
}

namespace DotNet.MinimalApi.Htmx.Infrastructure;

public interface IRouteDefinition
{
    IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints);
}

public static class RouteExtensions
{
    public static IEndpointRouteBuilder MapApplicationRoutes(this IEndpointRouteBuilder routeBuilder)
    {
        var routeDefinitions = typeof(Program).Assembly
            .GetTypes()
            .Where(t => t.IsAssignableTo(typeof(IRouteDefinition))
                        && t is { IsAbstract: false, IsInterface: false })
            .Select(Activator.CreateInstance)
            .Cast<IRouteDefinition>();
        foreach (var routeDefinition in routeDefinitions)
        {
            routeDefinition.MapRoutes(routeBuilder);
        }

        return routeBuilder;
    }
}
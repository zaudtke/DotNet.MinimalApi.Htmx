using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DotNet.MinimalApi.Htmx.Features.Home;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/", () => new RazorComponentResult<Index>());
        return endpoints;
    }
}
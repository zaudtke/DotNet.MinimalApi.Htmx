using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/ClickToEdit", () => new RazorComponentResult<Index>());

        return endpoints;
    }
}
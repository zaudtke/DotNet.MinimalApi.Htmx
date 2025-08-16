using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/ClickToEdit/{id:int}",
            async (int id, ContactService service) =>
            {
                var contact = await service.GetById(id);
                return new RazorComponentResult<Index>(new { Contact = contact });
            });

        return endpoints;
    }
}
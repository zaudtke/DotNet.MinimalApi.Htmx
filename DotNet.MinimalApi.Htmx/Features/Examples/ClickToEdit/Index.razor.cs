using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit.Components;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/ClickToEdit/{id:int}", GetContact);
        return endpoints;
    }
    
    private async Task<IResult> GetContact(int id, HttpContext httpContext, ContactService service)
    {
        var contact = await service.GetById(id);

        if (httpContext.Request.IsHtmx())
        {
            return new RazorComponentResult<ViewContact>(new { Contact = contact });
        }

        return new RazorComponentResult<Index>(new { Contact = contact });
    }
}
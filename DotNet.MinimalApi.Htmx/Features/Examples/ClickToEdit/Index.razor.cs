using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit.Comonents;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/ClickToEdit/{id:int}", 
            async Task<Results<RazorComponentResult<Index>, RazorComponentResult<ViewContact>>>
             (int id, HttpContext httpContext, [FromServices] ContactService service) =>
            {
                var contact = await service.GetById(id);

                if (httpContext.Request.IsHtmx())
                {
                    return new RazorComponentResult<ViewContact>(new { Contact = contact });
                }

                return new RazorComponentResult<Index>(new { Contact = contact });
            });
        return endpoints;
    }
}
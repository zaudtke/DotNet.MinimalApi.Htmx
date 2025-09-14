using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Features.Examples.ClickToLoad.Components;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToLoad;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/ClickToLoad", GetContacts);
        return endpoints;
    }

    private async Task<IResult> GetContacts(HttpContext httpContext, ContactService service, [FromQuery] int page = 1)
    {
        var allContacts = await service.GetAll();
        var contacts = allContacts.Skip((page - 1) * 10).Take(10);
        var loadMoreUrl = contacts.Count() < 10 ? null : $"/Examples/ClickToLoad?page={page + 1}";

        if(httpContext.Request.IsHtmx())
        {
            return new RazorComponentResult<ContactRows>(new { Contacts = contacts, LoadMoreUrl = loadMoreUrl });
        }
        else
        {
            // Return the full page
            return new RazorComponentResult<Index>(new { Contacts = contacts, LoadMoreUrl = loadMoreUrl });
        }
        
    }

}
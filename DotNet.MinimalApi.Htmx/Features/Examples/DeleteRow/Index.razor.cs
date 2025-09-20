using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.DeleteRow;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/DeleteRow", GetContacts);
        endpoints.MapDelete("/Examples/DeleteRow/{id:int}", DeleteContact);
        return endpoints;
    }
    
    private async Task<IResult> GetContacts(ContactService service)
    {
        var contacts = await service.GetAll();
        return new RazorComponentResult<Index>(new { Contacts = contacts.Take(10) });
    }

    private async Task<IResult> DeleteContact(int id, ContactService service)
    {
        await service.Delete(id);

        return Results.Ok();
    }
}
using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit.Components;

public partial class EditContact : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("Examples/ClickToEdit/EditContact/{id:int}", GetEditContact);
        endpoints.MapPut("Examples/ClickToEdit/EditContact/{id:int}", PutEditContact);
        return endpoints;
    }

    private static async Task<IResult> GetEditContact(int id, ContactService service)
    {
        var contact = await service.GetById(id);
        return new RazorComponentResult<EditContact>(new { Contact = contact });
    }

    private static async Task<IResult> PutEditContact(int id, [FromForm]Contact contact, ContactService service)
    {
        if (id != contact.Id)
        {
            return Results.BadRequest("Contact ID mismatch.");
        }
        _ = await service.Update(contact);
        return new RazorComponentResult<ViewContact>(new { Contact = contact });
    }
}
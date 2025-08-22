using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.ClickToEdit.Comonents;

public partial class EditContact : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("Examples/ClickToEdit/EditContact/{id:int}",
            async (int id, ContactService service) =>
            {
                var contact = await service.GetById(id);
                return new RazorComponentResult<EditContact>(new { Contact = contact });
            });
        
        endpoints.MapPut("Examples/ClickToEdit/EditContact/{id:int}",
            async (int id, [FromForm]Contact contact, ContactService service) =>
            {
                if (id != contact.Id)
                {
                    return Results.BadRequest("Contact ID mismatch.");
                }

                var updatedContact = await service.Update(contact);
                return new RazorComponentResult<ViewContact>(new { Contact = contact });
            });

        return endpoints;
    }
}
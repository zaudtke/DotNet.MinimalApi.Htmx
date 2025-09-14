using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNet.MinimalApi.Htmx.Features.Examples.BulkUpdate;

public partial class Index : IRouteDefinition
{
    public IEndpointRouteBuilder MapRoutes(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/Examples/BulkUpdate", GetContacts);
        endpoints.MapPost("/Examples/BulkUpdate", BulkUpdateContacts);
        return endpoints;
    }
    
    private async Task<IResult> GetContacts(ContactService service)
    {
        var contacts = await service.GetAll();
        return new RazorComponentResult<Index>(new { Contacts = contacts.Take(10) });
    }

    private async Task<IResult> BulkUpdateContacts([FromForm] int[] SelectedIds, ContactService service)
    {
        // In GetContacts we take the first 10 contacts.
        // It uses FindAll under the hood, so it returns them in Order by Id ascending.
        // Will will use that Logic to determine which contacts to update to Active=False when the Id is not in SelectedIds.

        var firstTenContacts = service.GetAll().Result.Take(10);
        int activatedCount = 0;
        int deactivatedCount = 0;

        foreach (var contact in firstTenContacts)
        {
            if (SelectedIds.Contains(contact.Id) && !contact.Active)
            {
                contact.Active = true;
                activatedCount++;
                await service.Update(contact);
            }
            else if (!SelectedIds.Contains(contact.Id) && contact.Active)
            {
                contact.Active = false;
                deactivatedCount++;
                await service.Update(contact);
            }
        }

        return Results.Content($"Activated: {activatedCount}, Deactivated: {deactivatedCount}");
    }
}
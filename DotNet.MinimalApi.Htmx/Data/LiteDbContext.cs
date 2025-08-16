using LiteDB;
using Microsoft.Extensions.Options;

namespace DotNet.MinimalApi.Htmx.Data;

public class LiteDbContext(IOptions<LiteDbSettings> settings)
{
    public LiteDatabase Database { get; set; } = new(settings.Value.DatabaseLocation);
}
using DotNet.MinimalApi.Htmx;
using DotNet.MinimalApi.Htmx.Data;
using DotNet.MinimalApi.Htmx.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
#if DEBUG
    // This enables the Watcher for Sass Files
    builder.Services.AddSassCompiler();
#endif

builder.Services.Configure<LiteDbSettings>(builder.Configuration.GetSection("LiteDbOptions"));
builder.Services.AddSingleton<LiteDbContext>();


var app = builder.Build();

// Database Setup
await DatabaseSetup.EnsureDatabase(app.Services);

// Configure the HTTP request pipeline.

app.UseHsts();
app.UseHttpsRedirection();
app.MapStaticAssets();
app.UseAntiforgery();
app.MapApplicationRoutes();
app.Run();

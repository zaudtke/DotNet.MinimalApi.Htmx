using DotNet.MinimalApi.Htmx.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorComponents();
#if DEBUG
    builder.Services.AddSassCompiler();
#endif

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.MapStaticAssets();
app.UseAntiforgery();
app.MapApplicationRoutes();
app.Run();

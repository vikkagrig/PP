using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SimpleBlazorServerApp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITimeService, TimeService>();

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();

app.UseStaticFiles();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

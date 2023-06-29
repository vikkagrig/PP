using BlazorWasmApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddTransient<ITimeService, TimeService>();
builder.Services.AddTransient<TimeFormatter>();

foreach (var service in builder.Services)
{
    Console.WriteLine(service.ServiceType);
}
builder.RootComponents.Add<HeadOutlet>("head::after");
await builder.Build().RunAsync();
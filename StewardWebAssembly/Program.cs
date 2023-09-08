using Blazor.AdminLte;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StewardWebAssembly;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7172")});

builder.Services.AddSyncfusionBlazor();
builder.Services.AddAdminLte();

//builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();

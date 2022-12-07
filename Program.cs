using Blazored.LocalStorage;
using Tienda_De_Instrumentos_Musicales;
using Tienda_De_Instrumentos_Musicales.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44352/api/") });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.TiendaMusicalSV.somee.com/api/") });

builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddMudServices();



await builder.Build().RunAsync();

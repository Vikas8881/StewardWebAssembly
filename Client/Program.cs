using Blazor.AdminLte;
using Blazored.LocalStorage;
using Client;
using Client.Service.authenticationService;
using Client.Service.DoctorRepo;
using Client.Service.Global;
using Client.Service.PatientComplain;
using Client.Service.PatientRepo;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

//Register Syncfusion license 
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqXE1hXk5Hd0BLVGpAblJ3T2ZQdVt5ZDU7a15RRnVfRF1lSHtWcEVqUHlZcw==;Mgo+DSMBPh8sVXJ1S0R+VVpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jT35Vd0BmX39XeXxSRQ==;ORg4AjUWIQA/Gnt2VFhiQlhPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhTcERmXHlfcHRVRWM=;MjMzNTU0NUAzMjMxMmUzMDJlMzBiYVBlbmxNbW1wKzg4V2NDb1V6a1FYK2xmUURVOHVXUW9sem1ESU1oTVlrPQ==;MjMzNTU0NkAzMjMxMmUzMDJlMzBCR28xSys1QURBemtkMS8rWTIwTmJwTnZxUm5kRmxxeHBOYmlyQUY4dzRrPQ==;NRAiBiAaIQQuGjN/V0d+Xk9NfV5AQmBIYVp/TGpJfl96cVxMZVVBJAtUQF1hSn5VdkNiXHpYcXRVTmdf;MjMzNTU0OEAzMjMxMmUzMDJlMzBuV2tvaGNqeUpST2tRa3lCejAwVGg1TXpzTFg2cWh1RGhPaDR0d3ltdVpZPQ==;MjMzNTU0OUAzMjMxMmUzMDJlMzBlV2J3RlRjcllRQTVOa1RiWVErb2VZWEdTOG8yUkJob0dNUnA0RkFCbmU0PQ==;Mgo+DSMBMAY9C3t2VFhiQlhPd11dXmJWd1p/THNYflR1fV9DaUwxOX1dQl9gSXhTcERmXHlfcHVTQGM=;MjMzNTU1MUAzMjMxMmUzMDJlMzBCSllVRDlyUzZRbk42c0xTWTdseUp2TXVLU0xrc2lNaFY1UlQ5Y1lOMENVPQ==;MjMzNTU1MkAzMjMxMmUzMDJlMzBZeVJ3ajFIbTVpZm9adGQ3aU9pMDh5bjRYSFF2YWdqOVZmaVdvZ21OM3lvPQ==;MjMzNTU1M0AzMjMxMmUzMDJlMzBuV2tvaGNqeUpST2tRa3lCejAwVGg1TXpzTFg2cWh1RGhPaDR0d3ltdVpZPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddAdminLte();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7004/api/") });

builder.Services.AddScoped<IPatient, PatientRepo>();
builder.Services.AddScoped<iDoctorRepo, DoctorRepo>();
builder.Services.AddScoped<IGlobalComplaint, GlobalComplaintRepo>();
builder.Services.AddScoped<IGlobalAdvice, GlobalAdviceRepo>();
builder.Services.AddScoped<IGlobalDignosis, GlobalDignosisRepo>();
builder.Services.AddScoped<IGlobalInvestigation, GlobalInvestigationRepo>();
builder.Services.AddScoped<IGlobalMedicine, GlobalMedicineRepo>();

builder.Services.AddScoped<IPatientComplainRepo, PatientComplainRepo>();
builder.Services.AddScoped<IauthenticationService, authenticationService>();
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddSyncfusionBlazor();


await builder.Build().RunAsync();

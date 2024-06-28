using Project.WebUI.AppCode;
using Project.WebUI.Controllers;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;
services.AddControllersWithViews();

services.AddSingleton<IRandomNumberGenerator, RandomNumberGenerator>();

WebApplication app = builder.Build();
IWebHostEnvironment env = builder.Environment;
if (env.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();

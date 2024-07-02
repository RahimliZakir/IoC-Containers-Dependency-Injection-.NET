using Project.WebUI.AppCode;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

IServiceCollection services = builder.Services;
services.AddControllersWithViews();

services.AddScoped<IRandomNumberGenerator, RandomNumberGenerator>();
//services.AddTransient<IRandomNumberGenerator, RandomNumberGenerator>();
//services.AddSingleton<IRandomNumberGenerator, RandomNumberGenerator>();

WebApplication app = builder.Build();
IWebHostEnvironment env = builder.Environment;
if (env.IsDevelopment())
    app.UseDeveloperExceptionPage();

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

app.Run();

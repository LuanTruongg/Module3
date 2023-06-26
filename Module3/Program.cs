
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Module3;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapAreaControllerRoute("blog_route", "Blog",
        "Manage/{controller}/{action}/{id?}");
app.MapAreaControllerRoute(name: "zebra_route",
                                     areaName: "Zebra",
                                     pattern: "Manage/{controller}/{action}/{id?}");
app.MapControllerRoute("default_route", "{controller}/{action}/{id?}");
//app.MapControllerRoute("blog_route", "Manage/{controller}/{action}/{id?}",
//        defaults: new { area = "Blog" }, constraints: new { area = "Blog" });
//app.MapControllerRoute("default_route", "{controller}/{action}/{id?}");

app.Run();
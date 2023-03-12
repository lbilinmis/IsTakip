using IsTakip.WebUI.Constraints;
using IsTakip.WebUI.Middlewares;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//MVC projeye dahil edilir
builder.Services.AddControllersWithViews();

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

app.CustomStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // burda canlý url bilgilerini çekip ilgili class yapýsýnda gelenurl bilgisi kontrolu rahat bir þekilde yapýlabilinir

    //app.MapControllerRoute(
    //name: "programlamaRoute",
    //pattern: "programlama/{dil}",
    //defaults: new { controller = "Home", action = "Index" },
    //constraints: new { dil = new Programlama() }
    //);

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
        //,
        //constraints: new { id = new IntRouteConstraint() }
        );


});



app.Run();

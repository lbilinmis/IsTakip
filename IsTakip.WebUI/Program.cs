using IsTakip.Business.Concrete;
using IsTakip.Business.Interfaces;
using IsTakip.DataAccess.Concrete.EntityFramework.Contexts;
using IsTakip.DataAccess.Concrete.EntityFramework.Repositories;
using IsTakip.DataAccess.Interfaces;
using IsTakip.Entities.Concrete;
using IsTakip.WebUI.InitializeHelper;
using IsTakip.WebUI.Middlewares;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

#region Dependency
//Dependecy Injection
builder.Services.AddScoped<IMissionService, MissionManager>();
builder.Services.AddScoped<IMissionDal, EfMissionRepositoryDal>();

builder.Services.AddScoped<IReportService, ReportManager>();
builder.Services.AddScoped<IReportDal, EfReportRepositoryDal>();

builder.Services.AddScoped<IImmediateService, ImmediateManager>();
builder.Services.AddScoped<IImmediateDal, EfImmediateRepositoryDal>();
#endregion

builder.Services.AddDbContext<IsTakipContext>();
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequiredLength = 1;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireNonAlphanumeric = false;
}).AddEntityFrameworkStores<IsTakipContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.CustomStaticFiles();

app.UseRouting();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<AppUser>>();
        var roleManager = services.GetRequiredService<RoleManager<AppRole>>();
        await IdentityInitializer.SeedData(userManager, roleManager);
    }
    catch (Exception)
    {
        throw;
    }
}


app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // area lar için kullanýlacak route aþaðýdaki þekilde olmalýdýr
    app.MapControllerRoute(
        name: "areas",
        pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
             );

    app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=SignIn}/{id?}"
         );
});



app.Run();

using Blog.DataAccessLayer.Context;
using Blog.DataAccessLayer.Extensions;
using Blog.Entity.Entities;
using Blog.Services.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));
builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
builder.Services.AddSession();
builder.Services.AddControllersWithViews().AddNToastNotifyToastr(new ToastrOptions() 
{
    PositionClass=ToastPositions.TopRight,
    TimeOut=3000

}).AddRazorRuntimeCompilation();


builder.Services.AddIdentity<AppUser, AppRole>(x => 
{
    x.SignIn.RequireConfirmedPhoneNumber = false;

    x.SignIn.RequireConfirmedAccount = false;
    x.SignIn.RequireConfirmedEmail = false;
    x.Password.RequiredLength = 1;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Password.RequiredUniqueChars = 0;

}).AddRoleManager<RoleManager<AppRole>>().
AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath=new PathString("/Admin/Auth/Login");
    x.LogoutPath=new PathString("/Admin/Auth/Logout");
    x.Cookie=new CookieBuilder
    {
        Name="BlogSiteApp",
        HttpOnly=true,
        SameSite=SameSiteMode.Strict,
        SecurePolicy=CookieSecurePolicy.SameAsRequest
    };
    x.SlidingExpiration=true;
    x.ExpireTimeSpan=TimeSpan.FromDays(1);
    x.AccessDeniedPath=new PathString("/Admin/Auth/AccesDenied");
});
// Add services to the container.


var app = builder.Build();

//builder.Services.AddDbContext<AppDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"),
//                         b => b.MigrationsAssembly("Blog.DataAccessLayer"));
//});
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
app.Run();

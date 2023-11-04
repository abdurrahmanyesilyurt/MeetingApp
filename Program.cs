
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();//mvc için 

var app= builder.Build();

app.UseStaticFiles();

app.UseRouting();

//app.MapDefaultControllerRoute();

app.MapControllerRoute(
  name: "default",
  pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
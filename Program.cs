using CimpleChat.Services;
using TPChat.Services;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://localhost:6969");
builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDataProtection();
builder.Services.AddSingleton<IGroupMessageService, GroupMessageService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();
app.UseRouting();
app.MapDefaultControllerRoute();
app.UseStaticFiles();

app.Run();

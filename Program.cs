using App.Services;
using AspMVCEcomerce.Models;
using AspMVCEcomerce.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<MyEcommerceDB>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyBlogContext"));
});

builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
});

builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<PlanetService>();

builder.Services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<MyEcommerceDB>()
                .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions> (options => {
    // Thiết lập về Password
    options.Password.RequireDigit = false; // Không bắt phải có số
    options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
    options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
    options.Password.RequireUppercase = false; // Không bắt buộc chữ in
    options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
    options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

    // Cấu hình Lockout - khóa user
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes (5); // Khóa 5 phút
    options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
    options.Lockout.AllowedForNewUsers = true;

    // Cấu hình về User.
    options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;  // Email là duy nhất

    // Cấu hình đăng nhập.
    options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
    options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại
    options.SignIn.RequireConfirmedAccount = true;

});

builder.Services.ConfigureApplicationCookie((options) => {
    options.LoginPath = "/login/";
    options.LogoutPath = "/logout/";
    options.AccessDeniedPath = "/denieAccess";
});

builder.Services.AddAuthentication()
                .AddGoogle(options => {
                    IConfigurationSection googleAuthSections = builder.Configuration.GetSection("Authentication:Google");
                    options.ClientId = googleAuthSections["ClientId"];
                    options.ClientSecret = googleAuthSections["ClientSecret"];
                    options.CallbackPath = "/Dang-nhap-tu-google";
                });

builder.Services.AddOptions();
var mailSetting = builder.Configuration.GetSection("MailSettings");
builder.Services.Configure<MailSettings>(mailSetting);
builder.Services.AddSingleton<IEmailSender, SendMailService>();

builder.Services.AddSingleton<IdentityErrorDescriber, AppIdentityErrorDescriber>();

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
app.UseStatusCodePages(async context =>
{
    var response = context.HttpContext.Response;
    response.ContentType = "text/plain";
    await response.WriteAsync($"Error: Status code {response.StatusCode}");
});


app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapAreaControllerRoute(
    name: "Product",
    pattern: "{controller}/{action=Index}/{id?}",
    areaName: "ProductManage"
);

app.MapAreaControllerRoute(
    name: "Database",
    pattern: "{controller}/{action=Index}/{id?}",
    areaName: "Database"
);

app.MapAreaControllerRoute(
    name: "Contact",
    pattern: "{controller}/{action=Index}/{id?}",
    areaName: "Contact"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();

using Blazored.LocalStorage;
using ElectronicStudentJournal;
using ElectronicStudentJournal.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Runtime;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "auth_token";
    options.LoginPath = "/Login";
    options.LogoutPath = "/logout";
    options.SlidingExpiration = true;
    options.ExpireTimeSpan = TimeSpan.FromHours(2);
    options.AccessDeniedPath = "/AccessDenied";
});
builder.Services.AddAuthorization();
builder.Services.AddHttpContextAccessor(); // potrzebne do SignInAsync
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddAuthorizationCore(); // Dla Blazor
//testowo moze usune
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=JournalDB;Trusted_Connection=True;");
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        context.Database.Migrate();    
        DbSeeder.Seed(context);      
    }
    catch (Exception ex)
    {
        Console.WriteLine("Błąd podczas seedowania bazy danych: " + ex.Message);
    }
}

app.Run();

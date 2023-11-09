using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using POSTO_ERP.Data;
using POSTO_ERP.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("FirebirdConnection");
builder.Services.AddDbContext<Contexto>(options =>
    options.UseFirebird(connectionString));

builder.Services.AddControllersWithViews();

//builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // remover essa chamada quando for colocar em produção
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<Contexto>()
    .AddDefaultTokenProviders();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.MapRazorPages();

app.Run();

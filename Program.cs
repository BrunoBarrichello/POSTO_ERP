using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using POSTO_ERP.Data;
using POSTO_ERP.Models;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Servi�os adicionados no container - 08/11/23 Bruno 22:32;
var connectionString = builder.Configuration.GetConnectionString("FirebirdConnection");
builder.Services.AddDbContext<Contexto>(options =>
    options.UseFirebird(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter(); // remover essa chamada quando for colocar em produ��o;

builder.Services.AddControllersWithViews();

// Estudar alguma forma de n�o utilizar o m�todo "IdentityUser" e aproveitar o banco do Mario (TABELA USUARIO), para evitar necessidade de trocar o login dos usu�rios;
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Contexto>();

var app = builder.Build();

// HTTP configurado para pipeline;
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
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

app.MapRazorPages();

app.Run();

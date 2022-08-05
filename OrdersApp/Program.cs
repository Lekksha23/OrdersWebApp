using OrdersApp.Data;
using OrdersApp.Infrastructurers;
using Microsoft.EntityFrameworkCore;
using OrdersApp.Extensions;

var builder = WebApplication.CreateBuilder(args);

string _connectionStringVariableName = "ORDERS_APP";
string connString = builder.Configuration.GetValue<string>(_connectionStringVariableName);

builder.Services.AddDbContext<OrdersAppContext>(opt
    => opt.UseSqlServer(connString));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.RegisterOrdersAppServices();
builder.Services.RegisterOrdersAppRepositories();
builder.Services.RegisterOrdersAppAutomappers();

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

app.UseMiddleware<GlobalExceptionHandler>();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();

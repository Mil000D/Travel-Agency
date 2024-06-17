using MASProject.Server.DAL.Context;
using Microsoft.EntityFrameworkCore;
using MASProject.Server.Extensions;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddDbContext<MainDbContext>(options =>
{
    options.UseSqlite($"Data Source={Path.Combine(Directory.GetCurrentDirectory(), @"Database\database.db")}");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();

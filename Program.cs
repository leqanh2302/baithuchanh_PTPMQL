<<<<<<< HEAD
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
=======
﻿using System.Security.Cryptography;
using NewApp.Model;
public class Program
{
    private static void Main(String[] args)
    {
    person ps1 = new person();
    person ps2 = new person();
    ps1.FullName = "NVA";
    ps1.Address = "HN";
    ps1.Display();
    ps2.Display();
    }
    public void 


}
>>>>>>> 7f45b2804ece5891e89d42a48a6c2417cf775427

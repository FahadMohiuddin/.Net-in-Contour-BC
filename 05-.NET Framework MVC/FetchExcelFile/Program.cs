using System.IO;
using System;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

if (app.Environment.IsDevelopment())
{

    string path = @"C:\Users\MohiuFah\Documents\Document.txt";

    if (File.Exists(path))
    {
        Console.WriteLine("Path Find");
        string data = File.ReadAllText(path);   
        Console.WriteLine(data);    
    }
    else
    {
        Console.WriteLine("Path not find");
    }
    Console.ReadLine();

}
if (app.Environment.IsProduction())
{
    string path1 = @"C:\Users\MohiuFah\Documents\Production.txt";
    if (File.Exists(path1))
    {
        Console.WriteLine("Path Find");
        string data1 = File.ReadAllText(path1);
        Console.WriteLine(data1);
    }
    else
    {
        Console.WriteLine("Path not find");
    }
    Console.ReadLine();
}



app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();




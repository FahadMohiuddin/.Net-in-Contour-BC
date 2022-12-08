using Microsoft.AspNetCore.Authentication.JwtBearer;
using AutherisationAuthentication.Controllers;
using Microsoft.IdentityModel.Tokens;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters()
    {
        IssuerSigningKey = HomeController.SecurityKey,
        ValidateIssuerSigningKey = true,
        ValidateAudience=false,
        ValidateIssuer=false
    };

});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.Use(async (context, next) =>
{
    var token = context.Request.Cookies["Token"];
    Console.WriteLine(token);
    context.Request.Headers.Add("Authorization","Bearer "+token);

    await next();
});

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

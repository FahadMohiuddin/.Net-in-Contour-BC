using AutherisationAuthentication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AutherisationAuthentication.Controllers
{
    
    public class HomeController : Controller
    {
        public static SymmetricSecurityKey SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jhgjgfjvjgjgffhgfhghfdfgdfgdfgdfgdfgdfgdfgf"));

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
    
        public IActionResult submit(login login)
        {

           
            if (login.Email == "admin" && login.Password == "admin") {

                ViewData["Email"] = login.Email;

                //key
                //var SecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jhgjgfjvjgjgffhgfhf"));

                //Algorithm With Key
                var Cridantial = new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256);



                var claims = new List<Claim>()
                {
                    new Claim("Name",login.Email),
                    new Claim("DOB","sdsfds"),

                };


                var token = new JwtSecurityToken(
                    signingCredentials: Cridantial,
                    claims: claims,
                    expires: DateTime.Now.AddHours(1)

                ) ;

                var option = new CookieOptions()
                {
                    Expires = DateTime.Now.AddHours(1),
                    Secure= true,
                    HttpOnly = true
                };


                var JWTToken = new JwtSecurityTokenHandler().WriteToken(token);

                ViewData["Token"] = JWTToken;
                HttpContext.Response.Cookies.Append("Token",JWTToken,option);
      


            }
            return View();
        }



        public IActionResult Privacy()
        {

            var value = User.Identity.IsAuthenticated;

            if (value) {
                return View();
            }
            else
            {
                return View("Error");
            }
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
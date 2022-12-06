using Microsoft.AspNetCore.Mvc;

namespace LoginFormIn.Net6.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult submit(Models.login res)
        {
            ViewBag.Name = res.User;
            ViewBag.Password = res.pass;
           
            return View();
        }
    }
}

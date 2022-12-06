using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("User/AttributeRouting/{id}/{num}/{num1}/{num2}")]
        public IActionResult AttributeRouting(int id, int num, int num1, int num2)
        {
            return View();
        }
    }
}

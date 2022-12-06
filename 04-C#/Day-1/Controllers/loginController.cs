using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_1.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult loginview()
        {
            return View();
        }



        public ActionResult submit(string Email,string Password)
        {
            if(Email == "admin" || Password == "admin")
            {
                ViewBag.Email = Email;
                ViewBag.Password = Password;
                return View();
            }
            else
            {
                return View("welcome");
            }

          

        }
    }
}
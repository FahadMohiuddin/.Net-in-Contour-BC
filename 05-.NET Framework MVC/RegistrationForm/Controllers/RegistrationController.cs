using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult registration()
        {
            return View();
        }



        public ActionResult submit(Models.Registration res)
        {
            ViewBag.Name = res.Name;
            ViewBag.Password = res.pass;
            ViewBag.Address = res.address;
            ViewBag.Email = res.Email;
            ViewBag.Phone = res.phone;

            return View();
        }

    }
}
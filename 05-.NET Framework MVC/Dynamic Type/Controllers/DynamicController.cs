using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Dynamic_Type.Controllers
{
    public class DynamicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Marks()
        {

            dynamic expando = new ExpandoObject();
            var marksModel = expando as IDictionary<string, object>;

            string studentName = "Alice";
            marksModel.Add("Name", studentName);
            marksModel.Add("Physics", "24");
            marksModel.Add("Chemistry", "45");


            return View(marksModel);

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace UserRegistrationFormWithSQL.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }
        public ActionResult submit(Models.Registration res)
        {
            ViewBag.username = res.username;
            ViewBag.fathername = res.fathername;
            ViewBag.address = res.address;
            ViewBag.city = res.city;

            var connection = new SqlConnection(@"Data Source=.; Initial Catalog=registration; Integrated Security=true");
            connection.Open();
            //var insert = new SqlCommand(String.Format("Insert into userinfo(userName,fatherName,userAddress,city) values('{0}','{1}','{2}','{3}')", res.username, res.fathername, res.address, res.city), connection);

            //var insert1 = insert.ExecuteReader();

            SqlCommand cmd = new SqlCommand("InsertStd", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("userName", res.username);
            cmd.Parameters.AddWithValue("fatherName", res.fathername);
            cmd.Parameters.AddWithValue("userAddress", res.address);
            cmd.Parameters.AddWithValue("city", res.city);

            cmd.ExecuteNonQuery();
            connection.Close();

            return View();
        }

       


    }
}

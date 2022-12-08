using System.Web;
using System.Web.Mvc;

namespace AutoUserRegistration_ASP.NET_Identity_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

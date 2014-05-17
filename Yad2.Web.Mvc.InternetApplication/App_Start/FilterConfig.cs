using System.Web;
using System.Web.Mvc;

namespace Yad2.Web.Mvc.InternetApplication
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
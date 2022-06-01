using System.Web;
using System.Web.Mvc;

namespace WebApplication1_CICD_TESTING
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

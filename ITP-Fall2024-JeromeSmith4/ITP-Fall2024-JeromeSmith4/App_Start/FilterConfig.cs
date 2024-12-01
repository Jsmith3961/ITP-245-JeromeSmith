using System.Web;
using System.Web.Mvc;

namespace ITP_Fall2024_JeromeSmith4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

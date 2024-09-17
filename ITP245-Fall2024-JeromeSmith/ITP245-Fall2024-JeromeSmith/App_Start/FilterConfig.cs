using System.Web;
using System.Web.Mvc;

namespace ITP245_Fall2024_JeromeSmith
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

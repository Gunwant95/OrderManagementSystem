using System.Web;
using System.Web.Mvc;

namespace Auth_and_ExceptionHandle
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

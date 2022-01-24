using System.Web;
using System.Web.Mvc;

namespace WebApplication1MVCProductsDataBaseFirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

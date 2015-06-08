using System.Web;
using System.Web.Mvc;

namespace Pruebas_ASP_C_sharp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
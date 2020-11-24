using System.Web;
using System.Web.Mvc;

namespace poc_new_Crud_using_template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

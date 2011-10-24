using System.Web.Mvc;
using System.Web.Routing;
using GovernorPortal.UI.Security;
using RequireHttpsAttribute = GovernorPortal.UI.Security.RequireHttpsAttribute;

namespace GovernorPortal.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // Filter specifying that by default, users must be logged on to access controller actions
            filters.Add(new LogonAuthorizeAttribute());

            // Filter specifying that the website will require SSL
            filters.Add(new RequireHttpsAttribute()); 

            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}
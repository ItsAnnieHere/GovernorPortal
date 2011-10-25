using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace GovernorPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = ConfigurationManager.AppSettings["WebsiteTitle"];
            try
            {
                // TODO - Mock this for tests
                if (HttpContext != null && HttpContext.Profile != null)
                {
                    ViewBag.HomePhone = HttpContext.Profile.GetPropertyValue("HomePhone");
                }
            }
            catch (PropertyNotFoundException)
            {
            }

            return View();
        }
    }
}

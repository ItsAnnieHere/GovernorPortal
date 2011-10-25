using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GovernorPortal.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Pebble Brook School Governor Portal";
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

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
            ViewBag.HomePhone = HttpContext.Profile.GetPropertyValue("HomePhone");

            return View();
        }
    }
}

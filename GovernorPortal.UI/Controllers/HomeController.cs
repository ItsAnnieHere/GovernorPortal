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
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = ConfigurationManager.AppSettings["WebsiteTitle"];
            ViewBag.ShowAllMeetings = false;

            return View();
        }
    }
}

using System.Web;
using System.Web.Mvc;

namespace GovernorPortal.UI.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.HomePhone = HttpContext.Profile.GetPropertyValue("HomePhone");

            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.HomePhone = HttpContext.Profile.GetPropertyValue("HomePhone");

            return View();
        }
    }
}

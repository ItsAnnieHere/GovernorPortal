using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GovernorPortal.UI.Controllers
{
    public class AdministrationController : Controller
    {
        //
        // GET: /Administration/
        [Authorize(Roles="Administrator,SecurityGuard")]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}

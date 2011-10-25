using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GovernorPortal.UI.Models;

namespace GovernorPortal.UI.Controllers
{
    public class MeetingController : Controller
    {
        //
        // GET: /Meeting/
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ShowMeetingEdit = true;

            return View();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            string meetingId = Request["MeetingId"];
            // var model = new MeetingModel(int.Parse(meetingId));
            var model = TempToRemove.GetMeeting();

            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Edit(MeetingModel model)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }
    }
}

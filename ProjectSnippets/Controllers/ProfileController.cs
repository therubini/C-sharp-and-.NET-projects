using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        // GET: PersonalProfiles/Create
        public ActionResult Create()      //Deleted parameter of "String Id" 10/21
        {
            ViewBag.ProfileID = User.Identity.GetUserId();
            return View();
        }

        // POST: PersonalProfiles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProfileId,AboutMe,TagLine")] PersonalProfile PersonalProfiles)
        { //Added a try/catch to prevent application from crashing when user tries to create another profile on top of existing profile
            try
            {
                if (ModelState.IsValid)
                {
                    db.Profile.Find(PersonalProfiles.ProfileID);
                    db.Profile.Add(PersonalProfiles);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "User profile already exists. Make any changes to the EDIT button. Thanks!");
            }
            ViewBag.ProfileID = new SelectList(db.Users, "Id", "DisplayName", PersonalProfiles.ProfileID);
            return View(PersonalProfiles);
        }
    }




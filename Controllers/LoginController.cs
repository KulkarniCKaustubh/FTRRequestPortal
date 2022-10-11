using FTRRequestPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FTRRequestPortal.Controllers
{
    public class LoginController : Controller
    {
        FTRContext db = new FTRContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(Login user)
        {
            if (ModelState.IsValid)
            {
                var data = (from e in db.Logins where e.Username == user.Username && e.Password == user.Password select e).Count();

                if (data > 0)
                {
                    return RedirectToAction("FTRRequestPage");
                }
                else
                {
                    ModelState.AddModelError("Username", "Login Request Denied");
                    return View(user);
                }
            }
            
            return View(user);
        }

        public ActionResult FTRRequestPage()
        {
            return View();
        }
    }
}
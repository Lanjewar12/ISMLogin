using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISMLogin.Models;

namespace ISMLogin.Controllers
{
    public class ManageController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Membership Model)
        {
            using (var context = new IMSEntities())
            {
                bool result = context.UserMasters.Any(x => x.Username == Model.Username && x.Password == Model.Password);  
                if(result==true)
                {
                    return RedirectToAction("Create","TeacherMasters");
                }
                ModelState.AddModelError("", "Username and password are incorrect");
            }
            return RedirectToAction("Create", "TeacherMasters");

        }

        public ActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult signup(UserMaster Model)
        {
            using (var context = new IMSEntities())
            {
                context.UserMasters.Add(Model);
                context.SaveChanges();

            }
            return RedirectToAction("Login");
        }

    }
}
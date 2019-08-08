using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SandboxProjectGlenn.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DatabaseContext())
                {
                    string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "MD5");
                    user.Password = hashresult;
                    var obj = db.Users.Where(a => a.Email.Equals(user.Email) && a.Password.Equals(user.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.UserId.ToString();
                        Session["UserName"] = obj.Name.ToString();
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult LogOff()
        {
            HttpContext.Session.RemoveAll();//This will remove all session from application
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}
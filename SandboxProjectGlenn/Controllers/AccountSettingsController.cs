using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SandboxProjectGlenn.Controllers
{
    public class AccountSettingsController : Controller
    {
        // GET: AccountSettings
        public ActionResult Account()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        [HttpPost]
        public ActionResult ChangePassword(string password)
        {
            if (password.Length>=7)
            {
                int userId = int.Parse(Session["UserID"].ToString());
                User user = new User();
                using (var db = new DatabaseContext())
                {
                    string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
                    user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                    user.Password = hashresult;
                    db.SaveChanges();
                }
                return RedirectToAction("LogOff", "Login");
            }
            else
            {
                return RedirectToAction("Account", "AccountSettings");

            }
        }
        [HttpPost]
        public ActionResult ChangeEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                int userId = int.Parse(Session["UserID"].ToString());
                User user = new User();
                using (var db = new DatabaseContext())
                {
                    user = db.Users.Where(u => u.UserId == userId).FirstOrDefault();
                    user.Email = email;
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Login");
            }
            else
            {
                return RedirectToAction("Account", "AccountSettings");
            }
        }
    }
}
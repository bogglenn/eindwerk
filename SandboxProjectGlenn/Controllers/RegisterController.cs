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
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(user.Email);
                if (match.Success)
                {
                    using (var db = new DatabaseContext())
                    {
                        if (user.Password.Length>=7)
                        {
                            var obj = db.Users.Where(a => a.Email == user.Email).FirstOrDefault();
                            if (obj != null)
                            {
                                return RedirectToAction("Index");

                            }
                            else
                            {
                                string hashresult = FormsAuthentication.HashPasswordForStoringInConfigFile(user.Password, "MD5");
                                user.Password = hashresult;
                                db.Users.Add(user);
                                db.SaveChanges();
                                return RedirectToAction("Index", "Login");
                            }
                        }
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Register");
                }
            }
            return RedirectToAction("Index");
        }
    }
}
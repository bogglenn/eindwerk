using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxProjectGlenn.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult TermsOfUse()
        {
            return View();
        }
    }
}
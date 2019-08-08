using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxProjectGlenn.Controllers
{
    public class RunDetailsController : Controller
    {
        // GET: RunDetails
        public ActionResult Index()
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

        public ActionResult InsertRuns(List<Run> runs)
        {
            using (var db = new DatabaseContext())
            {
                foreach (Run r in runs)
                {
                    int userId = int.Parse(Session["UserID"].ToString());
                    Run specificRun = db.Runs.SingleOrDefault(x => x.RunDetailsId == r.RunDetailsId && x.UserId == userId);
                    specificRun.AverageSpeed = " " +r.AverageSpeed;
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
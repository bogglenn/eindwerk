using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxProjectGlenn.Controllers
{
    public class RunController : Controller
    {

        public ActionResult Index(StartSchemaViewModel view)
        {
            if (Session["UserID"] != null)
            {
                string date = view.ChosenDate.Substring(4, 11);
                int monthIndex;
                string desiredMonth = date.Substring(0, 3);
                string[] MonthNames = CultureInfo.InvariantCulture.DateTimeFormat.MonthNames;
                string[] monthNamesFirstLetters = new string[MonthNames.Length];
                for (int i = 0; i < MonthNames.Length - 1; i++)
                {
                    monthNamesFirstLetters[i] = MonthNames[i].Substring(0, 3);
                }
                monthIndex = Array.IndexOf(monthNamesFirstLetters, desiredMonth) + 1;
                string month = "";
                if (monthIndex < 10)
                {
                    month = "0" + monthIndex.ToString();
                }
                else
                {
                    month = monthIndex.ToString();
                }

                string dateResult = month + "/" + date.Substring(4, 2) + "/" + date.Substring(7, 4) + " 00:00:00";

                using (var db = new DatabaseContext())
                {
                    int userId = int.Parse(Session["UserID"].ToString());
                    List<Run> runs = db.Runs.Where(x => x.UserId == userId).ToList();
                    List<Run> filteredRuns = new List<Run>();
                    foreach (Run r in runs)
                    {
                        string trainingDate = r.DateTraining.ToString(CultureInfo.InvariantCulture).Trim();
                        if (trainingDate == dateResult)
                        {
                            filteredRuns.Add(r);
                        }
                    }
                    foreach (Run r in filteredRuns)
                    {
                        RunDetails runDetails = db.RunDetails.SingleOrDefault(x => x.RunDetailsId == r.RunDetailsId);
                        runDetails.TrainingsActivity = db.TrainingsActivities.SingleOrDefault(x => x.TrainingsActivityId == runDetails.TrainingsActivityId);
                        r.RunDetails = db.RunDetails.SingleOrDefault(x => x.RunDetailsId == r.RunDetailsId);
                    }
                    return View(filteredRuns);
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

    }
}
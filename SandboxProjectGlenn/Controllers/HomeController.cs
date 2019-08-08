using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxProjectGlenn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                Dashboard latestRun = new Dashboard();
                float speedLastRun = 0;
                int timeInMin = 0;
                List<Run> nearDate = new List<Run>();
                using (var db = new DatabaseContext())
                {
                    int userId = int.Parse(Session["UserID"].ToString());
                    List<Run> runs = db.Runs.Where(x => x.UserId == userId).ToList();
                    Run nearestDate = runs.OrderBy(x => Math.Abs(DateTime.Today.Ticks - x.DateTraining.Ticks)).FirstOrDefault();
                    foreach (Run r in runs)
                    {
                       if(r.DateTraining == nearestDate.DateTraining)
                       {
                            nearDate.Add(r);
                       }
                    }
                    if (nearDate.Count != 0 )
                    {
                        foreach (Run r in nearDate)
                        {
                            int runDetailID = r.RunDetailsId;
                            List<RunDetails> runDetails = db.RunDetails.Where(x => x.RunDetailsId == runDetailID).ToList();
                            foreach (RunDetails rd in runDetails)
                            {
                                if (rd.RunDetailsId == r.RunDetailsId)
                                {
                                    if (r.AverageSpeed == null)
                                    {
                                        speedLastRun += 0;
                                        timeInMin += 0;
                                    }
                                    else
                                    {
                                    speedLastRun += float.Parse(r.AverageSpeed);
                                    timeInMin += rd.Duration;
                                    }
                                }
                            }
                        }
                    }
                    if (timeInMin >= 60)
                    {
                        string strMin;
                        string strHou;
                        int min = timeInMin % 60;
                        int hour = timeInMin / 60;
                        if (min <= 9) { strMin = "0" + min; } else { strMin = min + ""; }
                        if (hour <= 9) { strHou = "0" + hour; } else { strHou = hour+ ""; }
                        latestRun.Time = strHou+":" +strMin+":00";
                    }
                    else
                    {
                        latestRun.Time = "00:"+timeInMin+":00";
                    }
                    latestRun.AverageSpeed = (float)Math.Round(speedLastRun, 2);
                    latestRun.distance = (float)Math.Round((speedLastRun /60)*timeInMin);
                    latestRun.Steps = (int)Math.Round(latestRun.distance * 1312);
                    latestRun.Calories = (int)Math.Round(latestRun.distance * 49.37);
                    if (latestRun.distance <= 0)
                    {
                        latestRun.Time = "00:00:00";
                    }

                }
                return View(latestRun);
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
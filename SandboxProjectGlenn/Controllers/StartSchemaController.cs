using SandboxProjectGlenn.Context;
using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SandboxProjectGlenn.Controllers
{
    public class StartSchemaController : Controller
    {
        public ActionResult CreateSchema()
        {
            if(Session["UserID"]!=null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult SavedAgenda()
        {
            if (Session["UserID"] != null)
            {
                StartSchemaViewModel startSchemaViewModel = new StartSchemaViewModel();
                using (var db = new DatabaseContext())
                {
                    int userId = int.Parse(Session["UserID"].ToString());
                    List<Run> runs = db.Runs.Where(x => x.UserId == userId).ToList();
                    if (runs.Count == 0)
                    {
                        return RedirectToAction("CreateSchema", "StartSchema");
                    }
                    else
                    {
                        List<StartSchemaRun> runViewModels = new List<StartSchemaRun>();
                        int runDetailsId = runs[runs.Count - 1].RunDetailsId;
                        int finalRunDayCount = db.RunDetails.FirstOrDefault(x => x.RunDetailsId == runDetailsId).DayCount;
                        foreach (Run r in runs)
                        {
                            r.RunDetails = db.RunDetails.SingleOrDefault(x => x.RunDetailsId == r.RunDetailsId);
                        }
                        for (int i = 1; i <= finalRunDayCount; i++)
                        {
                            string workout = "";
                            List<Run> trainingsSchemasAppender = runs.Where(x => x.RunDetails.DayCount == i).ToList();
                            foreach (Run r in trainingsSchemasAppender)
                            {
                                TrainingsActivity trainingsActivity = db.TrainingsActivities.SingleOrDefault(x => x.TrainingsActivityId == r.RunDetails.TrainingsActivityId);
                                workout += r.RunDetails.Duration + " min " + trainingsActivity.Description + "  ";
                            }
                            runViewModels.Add(new StartSchemaRun
                            {
                                day = i,
                                workoutSchema = workout,
                                DateWorkout = trainingsSchemasAppender[0].DateTraining
                            });
                        }
                        startSchemaViewModel.Runs = runViewModels;
                        return View(startSchemaViewModel);
                    }
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        // GET: StartSchema
        public ActionResult Agenda(StartSchemaIndexView startSchemaIndexView)
        {
            if (Session["UserID"] != null)
            {

                string tempo = startSchemaIndexView.chosenSchema.Substring(0, 1);
                string intensity = startSchemaIndexView.chosenSchema.Substring(3, 9);
                string distance = startSchemaIndexView.chosenSchema.Substring(19, 4);
                
                using (var db = new DatabaseContext())
                {
                    int userId = int.Parse(Session["UserID"].ToString());
                    List<Run> removeRuns = db.Runs.Where(x => x.UserId == userId).ToList();
                    if (removeRuns.Count != 0)
                    {
                        db.Runs.RemoveRange(db.Runs.Where(r=> r.UserId == userId));
                        db.SaveChanges();
                    }

                    StartSchemaViewModel startSchemaViewModel = new StartSchemaViewModel();
                    int distanceId = db.TrainingDistances.SingleOrDefault(x => x.Description == distance).TrainingDistanceId;
                    int intensityId = db.TrainingIntensities.SingleOrDefault(x => x.Description.Contains(intensity)).TrainingIntensityId;
                    int tempoId = db.TrainingTempos.SingleOrDefault(x => x.TimesAWeek.ToString() == tempo).TrainingTempoId;

                    //get all the rundetails en the runs belonging to them
                    List<RunDetails> runDetails = db.RunDetails.Where(x => x.TrainingDistanceId == distanceId && x.TrainingIntensityId == intensityId && x.TrainingTempoId == tempoId).ToList();
                    int[] runDetailsIds = new int[runDetails.Count];
                    for (int i = 0; i < runDetails.Count; i++)
                    {
                        runDetailsIds[i] = runDetails[i].RunDetailsId;
                    }

                    List<Run> runs = db.Runs.Where(x => x.UserId == userId).ToList();
                    List<Run> Savedruns = db.Runs.Where(x => x.UserId == userId).ToList();

                    if (runs.Count == 0)
                    {
                        int trainingsTempo = db.TrainingTempos.SingleOrDefault(x => x.TrainingTempoId == tempoId).TimesAWeek;
                        List<int> counter = new List<int>(); ;
                        counter.Add(0);
                        if (trainingsTempo == 3)
                        {
                            counter.Add(2);
                            counter.Add(3);
                            counter.Add(2);
                        }
                        if (trainingsTempo == 4)
                        {
                            counter.Add(1);
                            counter.Add(2);
                            counter.Add(2);
                            counter.Add(2);
                        }
                        DateTime today = DateTime.Now.Date;
                        DateTime trainingsDay = DateTime.Now.Date;
                        for (int i = 1; i <= runDetails[runDetails.Count - 1].DayCount; i++)
                        {
                            List<RunDetails> trainingsSchemasAppender = runDetails.Where(x => x.DayCount == i).ToList();
                            foreach (RunDetails r in trainingsSchemasAppender)
                            {
                                if (trainingsTempo == 3)
                                {
                                    trainingsDay = today.AddDays(counter[0]);

                                    runs.Add(new Run
                                    {
                                        RunDetails = r,
                                        UserId = Int32.Parse(Session["UserID"].ToString()),
                                        DateTraining = trainingsDay
                                    });

                                }
                                if (trainingsTempo == 4)
                                {
                                    trainingsDay = today.AddDays(counter[0]);

                                    runs.Add(new Run
                                    {
                                        RunDetails = r,
                                        UserId = Int32.Parse(Session["UserID"].ToString()),
                                        DateTraining = trainingsDay
                                    });
                                }
                            }
                            today = trainingsDay;
                            if (counter[0] == 0) { counter.RemoveAt(0); }
                            else
                            {
                                counter.Add(counter[0]);
                                counter.RemoveAt(0);
                            }
                            db.Runs.AddRange(runs);
                            foreach (Run r in runs)
                            {
                                Savedruns.Add(r);
                            }
                            db.SaveChanges();
                            runs.Clear();
                        }
                    }
                    List<StartSchemaRun> runViewModels = new List<StartSchemaRun>();
                    for (int i = 1; i <= Savedruns[Savedruns.Count - 1].RunDetails.DayCount; i++)
                    {
                        string workout = "";
                        List<Run> trainingsSchemasAppender = Savedruns.Where(x => x.RunDetails.DayCount == i).ToList();
                        foreach (Run r in trainingsSchemasAppender)
                        {
                            TrainingsActivity trainingsActivity = db.TrainingsActivities.SingleOrDefault(x => x.TrainingsActivityId == r.RunDetails.TrainingsActivityId);
                            workout += r.RunDetails.Duration + " min " + trainingsActivity.Description + "  ";
                        }
                        runViewModels.Add(new StartSchemaRun
                        {
                            day = i,
                            workoutSchema = workout,
                            DateWorkout = trainingsSchemasAppender[0].DateTraining
                        });
                    }
                    startSchemaViewModel.Runs = runViewModels;
                    return View(startSchemaViewModel);
                }
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}
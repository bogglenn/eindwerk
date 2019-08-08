using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            TrainingDistance[] trainingDistances = { new TrainingDistance { Description = "05km" }, new TrainingDistance { Description = "10km" }, new TrainingDistance { Description = "21km" } };
            TrainingIntensity[] trainingIntensities = { new TrainingIntensity { Description = "fast - 10 weeks" }, new TrainingIntensity { Description = "slow - 15 weeks" } };
            TrainingsActivity[] trainingsActivities = { new TrainingsActivity {  Description = "Walk" }, new TrainingsActivity { Description = "Run" } };
            TrainingTempo[] trainingTempos = { new TrainingTempo {  TimesAWeek = 3 }, new TrainingTempo { TimesAWeek = 4 } };
            User[] users = { new User { Name = "Glenn", Email = "glenn@test.be", Password = "test123" }, new User { Name = "Kenneth", Email = "Kenneth@test.be", Password = "test123" } };

            context.TrainingDistances.AddRange(trainingDistances);
            context.TrainingIntensities.AddRange(trainingIntensities);
            context.TrainingsActivities.AddRange(trainingsActivities);
            context.TrainingTempos.AddRange(trainingTempos);
            context.Users.AddRange(users);
            //save changes otherwise you can't use the values as foreign keys
            context.SaveChanges();

            context.RunDetails.AddRange(SeedRunDetails());
            base.Seed(context);
        }

        public RunDetails[] SeedRunDetails()
        {
            return new RunDetails[]
{
                //Day 1
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                //day 2
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                //Day 3
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                //day 4
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                //day 5
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                //day 6
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                //day 7
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 6
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 6
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                //day 8
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                //day 9
                  new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 1,
                    Duration = 1
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 1,
                    Duration = 1
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 1,
                    Duration = 1
                },
                //day 10
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 14
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 14
                },
                //day 11
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 11,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
               //day 12
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 12,
                    TrainingsActivityId = 2,
                    Duration = 16
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 12,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 12,
                    TrainingsActivityId = 2,
                    Duration = 16
                },
                // day 13
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 13,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
                //day 14
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 14,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
                //day 15
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 15,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
                //day 16
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 16,
                    TrainingsActivityId = 2,
                    Duration = 35
                },
                //day 17
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                //day 18
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 18,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
                //day 19
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 19,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
                //day 20
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 20,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 20,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 20,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                //day 21
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 21,
                    TrainingsActivityId = 2,
                    Duration = 35
                },
                //day 22
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
                //day 23
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 23,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
                //day 24
                  new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 24,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 24,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 24,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
                //day 25
                 new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 25,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
                //day 26
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 26,
                    TrainingsActivityId = 2,
                    Duration = 16
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 26,
                    TrainingsActivityId = 1,
                    Duration = 2
                },
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 26,
                    TrainingsActivityId = 2,
                    Duration = 16
                },
                //day 27
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 27,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
                //day 28
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 28,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
                //day 29
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 29,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
                //day 30
                new RunDetails
                {
                    TrainingDistanceId = 1,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 1,

                    DayCount = 30,
                    TrainingsActivityId = 2,
                    Duration = 0
                },
            // 5km 10 weken 3 dagen end

            // 5km 15 weken 3 dagen begin
            // 5km 15 weken 3 dagen end

            // 5km 10 weken 4 dagen begin
            // 5km 10 weken 4 dagen end

            // 5km 15 weken 4 dagen begin
            // 5km 15 weken 4 dagen end

            // 10km 10 weken 3 dagen begin
            // 10km 10 weken 3 dagen end

            // 10km 15 weken 3 dagen begin
            // 10km 15 weken 3 dagen end

            // 10km 10 weken 4 dagen begin
            //day 1
            new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
               //day 2
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 3
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
               //day 4
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 5
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 35
                },
               //day 6
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 7
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 35
                },
               //day 8
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 9
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 10
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 5
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 5
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 11
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 11,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 12
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 12,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 13
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 13,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 14
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 14,
                    TrainingsActivityId = 2,
                    Duration = 50
                },               
               //day 15
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 15,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 16
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 16,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 17
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 18
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 18,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
               //day 19
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 19,
                    TrainingsActivityId = 1,
                    Duration = 20
                },
               //day 20
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 20,
                    TrainingsActivityId = 1,
                    Duration = 40
                },
               //day 21
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 21,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 22
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 23
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 23
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 23,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 24
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 24,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 25
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 25,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 26
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 26,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 27
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 27,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 28
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 28,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 29
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 29,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 30
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 30,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 31
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 31,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 32
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 33
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 33,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 34
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 34,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 35
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 35,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 36
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 36,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 37
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 37,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 38
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 38,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
               //day 39
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 39,
                    TrainingsActivityId = 1,
                    Duration = 40
                },
               //day 40
               new RunDetails
                {
                    TrainingDistanceId = 2,
                    TrainingIntensityId = 1,
                    TrainingTempoId = 2,

                    DayCount = 40,
                    TrainingsActivityId = 2,
                    Duration = 0
                },
            // 10km 10 weken 4 dagen end

            // 10km 15 weken 4 dagen begin
            // 10km 15 weken 4 dagen end

            // 21km 10 weken 3 dagen begin
            // 21km 10 weken 3 dagen end

            // 21km 15 weken 3 dagen begin
            //day 1
                new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 2
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 3
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 4
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 5
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 70
                },
               //day 6
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 7
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 8
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 23
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 9
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 10
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 11
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 11,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 12
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 12,
                    TrainingsActivityId = 2,
                    Duration = 90
                },
               //day 13
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 13,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 14
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 14,
                    TrainingsActivityId = 2,
                    Duration = 30
                },               
               //day 15
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 15,
                    TrainingsActivityId = 1,
                    Duration = 40
                },
               //day 16
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 16,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 17 
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 18
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 18,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 19
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 19,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 20
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 20,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 21
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 21,
                    TrainingsActivityId = 2,
                    Duration = 95
                },
               //day 22
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 90
                },
               //day 23
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 23,
                    TrainingsActivityId = 2,
                    Duration = 55
                },
               //day 24
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 24,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 25
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 25,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 26
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 26,
                    TrainingsActivityId = 2,
                    Duration = 90
                },
               //day 27
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 27,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 28
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 28,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 29
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 29,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
               //day 30
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 30,
                    TrainingsActivityId = 1,
                    Duration = 40
                },
               //day 31
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 31,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 32
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 27
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 12
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 33
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 33,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 34
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 34,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 35
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 35,
                    TrainingsActivityId = 2,
                    Duration = 70
                },
               //day 36
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 36,
                    TrainingsActivityId = 2,
                    Duration = 95
                },
               //day 37
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 37,
                    TrainingsActivityId = 2,
                    Duration = 90
                },
               //day 38
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 38,
                    TrainingsActivityId = 2,
                    Duration = 55
                },
               //day 39
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 39,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 40
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 40,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 41
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 41,
                    TrainingsActivityId = 2,
                    Duration = 120
                },
               //day 42
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 42,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 43
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 43,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 44
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 44,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
               //day 45
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 1,

                    DayCount = 40,
                    TrainingsActivityId = 2,
                    Duration = 0
                },
            // 21km 15 weken 3 dagen end

            // 21km 10 weken 4 dagen begin
            
            //day 1
            new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 1,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 2
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 2,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 3
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 3,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 4
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 4,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 5
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 5,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 6
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 6,
                    TrainingsActivityId = 2,
                    Duration = 70
                },
               //day 7
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 7,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 8
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 8,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 9
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 9,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 10
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 23
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 8
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 10,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 11
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 11,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 12
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 12,
                    TrainingsActivityId = 2,
                    Duration = 80
                },
               //day 13
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 13,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 14
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 14,
                    TrainingsActivityId = 2,
                    Duration = 80
                },               
               //day 15
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 15,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 16
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 16,
                    TrainingsActivityId = 2,
                    Duration = 75
                },
               //day 17
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 17,
                    TrainingsActivityId = 2,
                    Duration = 40
                },
               //day 18
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 18,
                    TrainingsActivityId = 2,
                    Duration = 30
                },
               //day 19
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 19,
                    TrainingsActivityId = 1,
                    Duration = 20
                },
               //day 20
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 20,
                    TrainingsActivityId = 1,
                    Duration = 40
                },
               //day 21
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 21,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 22
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 25
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 10
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 1,
                    Duration = 3
                },
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 22,
                    TrainingsActivityId = 2,
                    Duration = 15
                },
               //day 23
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 23,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 24
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 24,
                    TrainingsActivityId = 2,
                    Duration = 75
                },
               //day 25
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 25,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 26
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 26,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 27
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 27,
                    TrainingsActivityId = 2,
                    Duration = 50                },
               //day 28
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 28,
                    TrainingsActivityId = 2,
                    Duration = 95
                },
               //day 29
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 29,
                    TrainingsActivityId = 2,
                    Duration = 90
                },
               //day 30
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 30,
                    TrainingsActivityId = 2,
                    Duration = 55
                },
               //day 31
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 31,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 32
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 32,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 33
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 33,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 34
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 34,
                    TrainingsActivityId = 2,
                    Duration = 120
                },
               //day 35
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 35,
                    TrainingsActivityId = 2,
                    Duration = 50
                },
               //day 36
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 36,
                    TrainingsActivityId = 2,
                    Duration = 60
                },
               //day 37
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 37,
                    TrainingsActivityId = 2,
                    Duration = 45
                },
               //day 38
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 38,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
               //day 39
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 39,
                    TrainingsActivityId = 2,
                    Duration = 20
                },
               //day 40
               new RunDetails
                {
                    TrainingDistanceId = 3,
                    TrainingIntensityId = 2,
                    TrainingTempoId = 2,

                    DayCount = 40,
                    TrainingsActivityId = 2,
                    Duration = 0
                },
                // 21km 10 weken 4 dagen end

                // 21km 15 weken 4 dagen begin
                // 21km 15 weken 4 dagen end

            };

        }
    }
}
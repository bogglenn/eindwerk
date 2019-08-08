using SandboxProjectGlenn.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("GlennDbSand") {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<Run> Runs { get; set; }
        public DbSet<RunDetails> RunDetails { get; set; }
        public DbSet<TrainingDistance> TrainingDistances { get; set; }
        public DbSet<TrainingIntensity> TrainingIntensities { get; set; }
        public DbSet<TrainingsActivity> TrainingsActivities { get; set; }
        public DbSet<TrainingTempo> TrainingTempos { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
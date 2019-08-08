using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class RunDetails
    {
        [Key]
        public int RunDetailsId { get; set; }

        public int TrainingDistanceId { get; set; }
        public TrainingDistance TrainingDistance { get; set; }

        public int TrainingIntensityId { get; set; }
        public TrainingIntensity TrainingIntensity { get; set; }

        public int TrainingTempoId { get; set; }
        public TrainingTempo TrainingTempo { get; set; }

        public int DayCount { get; set; }

        public int TrainingsActivityId { get; set; }
        public TrainingsActivity TrainingsActivity { get; set; }

        public int Duration { get; set; }
    }
}
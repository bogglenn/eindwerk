using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class TrainingTempo
    {
        [Key]
        public int TrainingTempoId { get; set; }

        public int TimesAWeek { get; set; }
    }
}
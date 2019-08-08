using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class Date
    {
        public string RunDescription { get; set; }
        public int DayCount { get; set; }
        public int IntensityTraining { get; set; }
        public DateTime DateOfTraining { get; set; }
    }
}
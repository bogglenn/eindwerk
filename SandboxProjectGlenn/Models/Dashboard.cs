using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class Dashboard
    {
        public float AverageSpeed { get; set; }
        public float distance { get; set; }
        public string Time { get; set; }

        public int Steps { get; set; }

        public int Calories { get; set; }
       
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class Run
    {
        [Key]
        public int RunId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RunDetailsId { get; set; }
        public RunDetails RunDetails { get; set; }

        public string AverageSpeed { get; set; }

        public DateTime DateTraining { get; set; }
    }
}
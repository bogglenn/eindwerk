using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class TrainingDistance
    {
        [Key]
        public int TrainingDistanceId { get; set; }

        public string Description { get; set; }
    }
}
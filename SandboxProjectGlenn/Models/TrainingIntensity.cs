using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class TrainingIntensity
    {
        [Key]
        public int TrainingIntensityId { get; set; }

        public string Description { get; set; }
    }
}
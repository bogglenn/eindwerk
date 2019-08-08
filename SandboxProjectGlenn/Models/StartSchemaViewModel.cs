using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SandboxProjectGlenn.Models
{
    public class StartSchemaViewModel
    {
        public StartSchemaViewModel()
        {
            Runs = new List<StartSchemaRun>();
        }

        public List<StartSchemaRun> Runs { get; set; }

        public string ChosenDate { get; set; }
    }
}
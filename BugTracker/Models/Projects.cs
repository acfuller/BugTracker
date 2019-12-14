using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Projects
    {
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Project name")]
        public string projectName { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Developer name")]
        public string devName { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Comments")]
        public string comments { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Status")]
        public string status { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Date")]
        public string date { get; set; }


    }
}

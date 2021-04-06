using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string TechnologyUsed { get; set; }
        public string LanguageUsed { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class Education
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EducationID { get; set; }
        public string Title { get; set; }
        public string CollegeName { get; set; }
        public double GPA { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
    }
}

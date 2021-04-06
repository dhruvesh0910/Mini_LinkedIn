using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class WorkExperience
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int WorkID { get; set; }
        public string Position { get; set; }
        public string Area { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public int YearOfExperience { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
        public ICollection<Reference> References { get; set; }

    }
}

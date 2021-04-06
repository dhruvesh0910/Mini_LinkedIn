using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class Achievement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        
        public int AchievementID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }

    }
}

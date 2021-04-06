using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        //[Key]
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public long MobileNo { get; set; }
        public string EmailID { get; set; }

        public ICollection<WorkExperience> WorkExperiences { get; set; }
        public ICollection<Education> Educations { get; set; }
        public ICollection<Achievement> Achievements { get; set; }
        public ICollection<Project> Projects { get; set; }
        public ICollection<Interest> Interests { get; set; }
    }
}

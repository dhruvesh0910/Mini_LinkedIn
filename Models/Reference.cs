using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class Reference
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int RefID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Role { get; set; }
        public string Position { get; set; }
        public string EmailID { get; set; }
        public int WorkID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace mini_linkedIn.Models
{
    public class Interest
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int HobbyID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }

        public User user { get; set; }
    }
}

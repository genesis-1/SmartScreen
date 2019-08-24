using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("RESIDENCE_TYPE")]
    public class ResidenceType
    {
 
        [Key]
        [Required]
        [Column("code")]
        public string Code{ get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }


    }
}

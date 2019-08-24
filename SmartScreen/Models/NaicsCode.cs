using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("NAICS_CODE")]
    public class NaicsCode
    {
        [Key]
        [Required]
        [Column("naics_codes")]
        public string Code { get; set; }

        [Required]
        [Column("naics_description")]
        public string Description { get; set; }
    }
}

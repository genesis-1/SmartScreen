using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("VISION_SBU")]
    public class VisionSBU
    {
        [Key]
        [Required]
        [Column("vision_sbu")]
        public string VisionSbu { get; set; }

        [Required]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("definition")]
        public string Definition { get; set; }
    }
}

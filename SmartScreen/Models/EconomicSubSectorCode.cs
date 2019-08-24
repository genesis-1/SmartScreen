using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("ECONOMIC_SUB_SECTOR_CODE")]
    public class EconomicSubSectorCode
    {
     
        [Key]
        [Required]
        [Column("economic_sub_sector_bnr")]
        public int Code { get; set; }

        [Required]
        [Column("economic_sub_sector_bnr_desc")]
        public string Description { get; set; }
    }
}

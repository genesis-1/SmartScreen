using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("BNR_CUSTOMER")]
    public class BnrCustomer
    {
        [Key]
        [Required]
        [Column("cust_no")]
        public string CustomerNumber { get; set; }

        [Required]
        [Column("Cust_name")]
        public string CustomerName { get; set; }

        [Required]
        [Column("vision_sbu")]
        public string VisionSBU { get; set; }
        [ForeignKey("VisionSBU")]
        public virtual VisionSBU Vision { get; set; }

        [Required]
        [Column("village")]
        public string VillageList { get; set; }
        [ForeignKey("VillageList")]
        public virtual VillageList Village { get; set; }

        [Required]
        [Column("residence_type")]
        public string ResidenceTypeCode { get; set; }
        [ForeignKey("ResidenceTypeCode")]
        public virtual ResidenceType Residence { get; set; }

        [Required]
        [Column("education")]
        public string EducationCode { get; set; }
        [ForeignKey("EducationCode")]
        public virtual Education Education { get; set; }

        [Required]
        [Column("naics_code")]
        public string NaiscCode { get; set; }
        [ForeignKey("NaiscCode")]
        public virtual NaicsCode NaicsCode  { get; set; }

        [Required]
        [Column("sub_sector_code")]
        public int EconomicSubSectorCodeId { get; set; }
        [ForeignKey("EconomicSubSectorCodeId")]
        public virtual EconomicSubSectorCode EconomicSubSectorCode { get; set; }

        [Required]
        [Column(" sub_sector_code_isic")]
        public int EconomicSubSectorCodeISICId { get; set; }
        [ForeignKey("EconomicSubSectorCodeISICId")]
        public virtual EconomicSubSectorCodeISIC EconomicSubSectorCodeISIC { get; set; }
    }
}

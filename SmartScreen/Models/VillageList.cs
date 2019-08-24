using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("VILLAGE_LIST")]
    public class VillageList
    {
    
        [Key]
        [Required]
        [Column("village_list")]
        public string Villagelist { get; set; }

        [Required]
        [Column("vilage_list_description")]
        public string VillagelistDescription { get; set; }

        [Required]
        [Column("cell_list")]
        public string CellList { get; set; }

        [Required]
        [Column("cell_list_description")]
        public string CellListDescription { get; set; }

        [Required]
        [Column("sector_list")]
        public string SectorList { get; set; }

        [Required]
        [Column("sector_list_description")]
        public string SectorListDescription { get; set; }

        [Required]
        [Column("district_list")]
        public string DistrictList { get; set; }

        [Required]
        [Column("district_list_description")]
        public string DistrictListDescription { get; set; }

        [Required]
        [Column("province_list")]
        public string ProvinceList { get; set; }

        [Required]
        [Column("province_list_description")]
        public string ProvinceListDescription { get; set; }
    }
}

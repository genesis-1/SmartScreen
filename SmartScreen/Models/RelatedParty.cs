using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("RELATED_PARTY")]
    public class RelatedParty
    {
        [Key]
        [Required]
        [Column("related_party")]
        public string RelatedPart { get; set; }

        [Required]
        [Column("related_party_description")]
        public string RelatedPartyDescription { get; set; }
    }
}

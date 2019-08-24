using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    [Table("EDUCATION")]
    public class Education
    {

        [Key]
        [Required]
        [Column("code_edu")]
        public string Code { get; set; }

        [Required]
        [Column("description_edu")]
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models
{
    public class CustomerAccount
    {
        [Key]
        [Required]
        public int CustomerAccountNumber { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }


    }
}

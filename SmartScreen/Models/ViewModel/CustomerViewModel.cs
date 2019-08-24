using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartScreen.Models.ViewModel
{
    public class CustomerViewModel
    {
        public BnrCustomer BnrCustomer { get; set; }

        [Required]
        public int SelectedCustomerAccountId { get; set; }
        public IEnumerable<CustomerAccount> CustomerAccounts { get; set; }

        [Required]
        public int SelectedEconomicSubSectorCodes { get; set; }
        public IEnumerable<EconomicSubSectorCode> EconomicSubSectorCodes { get; set; }

        [Required]
        public int EconomicSubSectorCodeIsicsId { get; set; }
        public IEnumerable<EconomicSubSectorCodeISIC> EconomicSubSectorCodeISICs { get; set; }

        [Required]
        public int selectedEducationId { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        [Required]
        public int SelectedNaiscodeId { get; set; }
        public IEnumerable<NaicsCode> NaicsCodes { get; set; }

        [Required]
        public int selectedVilageListId { get; set; }
        public IEnumerable<VillageList> VillageLists { get; set; }

        [Required]
        public int SelectedResidenceTypeId { get; set; }
        public IEnumerable<ResidenceType> ResidenceTypes { get; set; }

         [Required]
        public int SelectedVisionSBUId { get; set; }
        public IEnumerable<VisionSBU> VisionSBUs { get; set; }
    }
}

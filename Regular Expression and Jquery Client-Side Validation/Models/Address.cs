using System.ComponentModel.DataAnnotations;

namespace Regular_Expression_and_Jquery_Client_Side_Validation.Models
{
    public class Address
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Mahalle")]
        public string Neighborhood { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "Sokak")]
        public string Street { get; set; }

        [Display(Name = "Kapı Numarası")]
        public int No { get; set; }

        [Required]
        [MinLength(3)]
        [Display(Name = "İlçe")]
        public string Town { get; set; }


        [Range(1, 81)]
        [Display(Name = "İl Palaka No")]
        public int CityId { get; set; }
    }
}

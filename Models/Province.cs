using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegistrationWizard.Models
{
    public class Province
    {
        [Column("ProvinceId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Province name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }
        public Country Country { get; set; } = null!;
    }
}

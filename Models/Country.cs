using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegistrationWizard.Models
{
    public class Country
    {
        [Column("CountryId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Country name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; } = null!;

        public List<Province> Provinces { get; set; } = new List<Province>();
    }
}

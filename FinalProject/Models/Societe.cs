using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Societe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le champ Libellé est requis")]
        [Display(Name = "Libellé")]
        [StringLength(50, MinimumLength = 3)]
        public string? Lib { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Adresse { get; set; }


        [Required]
        [StringLength(8)]
        [Display(Name = "Téléphone")]
        public string? Tel { get; set; }

        public virtual ICollection<PFE>? PFEs { get; set; }
    }

}

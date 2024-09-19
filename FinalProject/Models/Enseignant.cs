using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Enseignant
    {
        public int Id { get; set; }

        [Display(Name = "Nom de l'Enseignant ")]
        [Required(ErrorMessage = "Le champ Nom est requis")]
        [StringLength(30, MinimumLength = 3)]
        public string? Nom { get; set; }


        [Display(Name = "Prenom de l'Enseignant ")]
        [Required(ErrorMessage = "Le champ Prénom est requis")]
        [StringLength(30, MinimumLength = 3)]
        public string? Prenom { get; set; }

        public string NomPrenom
        {
            get
            {
                return Nom + " " + Prenom;
            }
        }
        public virtual ICollection<PFE>? EncadrantPFEs { get; set; }
        [InverseProperty("President")]
        public virtual ICollection<Soutenance>? SoutenancesAsPresident { get; set; }

        [InverseProperty("Rapporteur")]
        public virtual ICollection<Soutenance>? SoutenancesAsRapporteur { get; set; }
    }

}

using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Etudiant
    {
        public string NomPrenom
        {
            get
            {
                return Nom + " " + Prenom;
            }
        }
        public int Id { get; set; }


        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Le champ Nom est requis")]
        public string? Nom { get; set; }


        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "Le champ Prénom est requis")]
        public string? Prenom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Naissance")]
        public DateTime DateNaiss { get; set; }

        public virtual ICollection<PFE_Etudiant>? PFE_Etudiants { get; set; }

    }
}


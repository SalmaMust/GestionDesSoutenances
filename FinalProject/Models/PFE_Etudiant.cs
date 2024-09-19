using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class PFE_Etudiant
    {
        public int Id { get; set; }

        [Display(Name = "Titre du PFE")]
        public int PFEID { get; set; }

        [Display(Name = "Nom de l'Etudiant ")]

        public int EtudiantID { get; set; }

        [ForeignKey("PFEID")]
        public virtual PFE? PFE { get; set; }

        [ForeignKey("EtudiantID")]
        public virtual Etudiant? Etudiant { get; set; }
    }
}

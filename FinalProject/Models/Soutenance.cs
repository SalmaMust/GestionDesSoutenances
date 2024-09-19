using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Soutenance
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Heure")]
        public DateTime Heure { get; set; }


        [Display(Name = "Titre du PFE")]
        public int? PFEID { get; set; }

        [Display(Name = "President")]
        public int? PresidentID { get; set; }

        [Display(Name = "Rapporteur")]
        public int? RapporteurID { get; set; }

        [ForeignKey("PFEID")]
        public virtual PFE? PFE { get; set; }

        [ForeignKey("PresidentID")]
        [InverseProperty("SoutenancesAsPresident")]
        public virtual Enseignant? President { get; set; }

        [ForeignKey("RapporteurID")]
        [InverseProperty("SoutenancesAsRapporteur")]

        public virtual Enseignant? Rapporteur { get; set; }



    }
}

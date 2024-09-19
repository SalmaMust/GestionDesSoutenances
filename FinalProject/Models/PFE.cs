using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class PFE
    {
        public int PFEID { get; set; }

        [Required(ErrorMessage = "Le champ Titre est requis")]
        public string? Titre { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Le champ Description est requis")]
        public string? Desc { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Début")]
        public DateTime DateD { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Fin")]
        public DateTime DateF { get; set; }
        [Display(Name = "Encadrant")]

        public int EncadrantID { get; set; }

        [Display(Name = "SOCIETE")]

        public int SocieteID { get; set; }

        [ForeignKey("EncadrantID")]
        public Enseignant? Encadrant { get; set; }



        [ForeignKey("SocieteID")]
        public virtual Societe? Societe { get; set; }

        public virtual ICollection<PFE_Etudiant>? PFE_Etudiants { get; set; }

        public virtual ICollection<Soutenance>? Soutenances { get; set; }


    }
}

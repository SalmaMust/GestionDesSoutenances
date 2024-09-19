using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
  
    public class SoutenanceContext : DbContext
    {
        public SoutenanceContext (DbContextOptions<SoutenanceContext> options)
            : base(options)
        {
        }

        public DbSet<Enseignant> Enseignant { get; set; }
        public DbSet<Etudiant> Etudiant { get; set; } 
        public DbSet<PFE> PFE { get; set; } 
        public DbSet<PFE_Etudiant> PFE_Etudiant { get; set; }
        public DbSet<Societe> Societe { get; set; } 
        public DbSet<Soutenance> Soutenance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Soutenance>()
                .HasOne(s => s.President)                    // Soutenance has one Enseignant as President
                .WithMany(e => e.SoutenancesAsPresident)    // Enseignant has many Soutances as President
                .HasForeignKey(s => s.PresidentID)          // Foreign key property in Soutenance
                .OnDelete(DeleteBehavior.Restrict)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Soutenance>()
               .HasOne(s => s.Rapporteur)                    // Soutenance has one Enseignant as Rapporteur
                .WithMany(e => e.SoutenancesAsRapporteur)    // Enseignant has many Soutances as Rapporteur
                .HasForeignKey(s => s.RapporteurID)          // Foreign key property in Soutenance
                .OnDelete(DeleteBehavior.Restrict)
                .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(modelBuilder);

        }
        
    }
   
}

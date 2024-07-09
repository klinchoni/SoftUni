using Microsoft.EntityFrameworkCore;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase.Data
{
    public class HospitalContext:DbContext
    {
        private const string ConnectionString =
            "Server=DESKTOP-SENJ7PO\\SQLEXPRESS;Database=HospitalDatabase;Integrated Security=True";   
        
        public HospitalContext()
        {
            
        }

        public HospitalContext(DbContextOptions options)
        :base(options)
        {
            
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PatientMedicament> PatientsMedicaments { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .Property(p => p.Email)
                .IsUnicode(false);

            modelBuilder.Entity<PatientMedicament>(entity =>
            {
                entity.HasKey(pk => new { pk.PatientId, pk.MedicamentId });
            });
        }
    }
}

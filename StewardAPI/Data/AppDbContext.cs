using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;

using StewardAPI.Models;
using StewardAPI.Seed;

namespace StewardAPI.Data
{
    public partial class AppDbContext : IdentityDbContext<ApplicationUser>
    {
     
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<CityList> CityLists { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<GenComplaints> GenComplaintsLists { get; set; }
        public virtual DbSet<GenDignosis> GenDiagnos { get; set; }
        public virtual DbSet<GenLabInvestigation> GenlabInvestigation { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<GenAdvice> GenAdvises { get; set; }
        public virtual DbSet<GenMedicine> GenMedicine { get; set; }
       public virtual DbSet<pComplain> PComplains { get; set; }
       public virtual DbSet<pAdvice> PAdvice { get; set; }
       public virtual DbSet<pDignosis> PDignosis { get; set; }
       public virtual DbSet<pInvestigation> PInvestigation { get; set; }
       public virtual DbSet<PatientMedicines> PatientMedicines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();


            modelBuilder.Entity<CityList>(entity =>
            {
                entity.ToTable("CityList");
            });

           

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");
            });

            modelBuilder.Entity<GenComplaints>(entity =>
            {
                entity.ToTable("GenComplaintsList");
            });

          
            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.HasIndex(e => e.DoctorId, "IX_Patient_DoctorId");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Opdtype)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                //entity.HasOne(d => d.Doctor)
                //    .WithMany(p => p.Patients)
                //    .HasForeignKey(d => d.DoctorId);
            });

            //OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

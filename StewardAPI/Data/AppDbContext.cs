using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
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
        public virtual DbSet<Diagnosis> Diagnoses { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<GenComplaints> GenComplaintsLists { get; set; }
        public virtual DbSet<GenDiagnosis> GenDiagnosisLists { get; set; }
        public virtual DbSet<GenMedicines> GenMedicinesLists { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientAdvise> PatientAdvises { get; set; }
        public virtual DbSet<PatientComplaint> PatientComplaints { get; set; }
        public virtual DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }
        public virtual DbSet<PatientInvestigation> PatientInvestigations { get; set; }
        public virtual DbSet<PatientMedicine> PatientMedicines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();


            modelBuilder.Entity<CityList>(entity =>
            {
                entity.ToTable("CityList");
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("diagnosis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diagnosisname)
                    .IsRequired()
                    .HasColumnName("diagnosisname");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.ToTable("Doctor");
            });

            modelBuilder.Entity<GenComplaints>(entity =>
            {
                entity.ToTable("GenComplaintsList");
            });

            modelBuilder.Entity<GenDiagnosis>(entity =>
            {
                entity.ToTable("GenDiagnosisList");
            });

            modelBuilder.Entity<GenMedicines>(entity =>
            {
                entity.ToTable("GenMedicinesList");
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

            modelBuilder.Entity<PatientAdvise>(entity =>
            {
                entity.ToTable("PatientAdvise");

                entity.Property(e => e.Datetime)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PatientComplaint>(entity =>
            {
                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PatientDiagnosis>(entity =>
            {
                entity.ToTable("PatientDiagnosis");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PatientInvestigation>(entity =>
            {
                entity.ToTable("PatientInvestigation");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvestigationName)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PatientMedicine>(entity =>
            {
                entity.ToTable("PatientMedicine");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.WhenTake).HasColumnName("when_take");
            });

            //OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

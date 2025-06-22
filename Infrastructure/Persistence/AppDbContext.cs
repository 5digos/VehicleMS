using Domain.Entities;
using Infrastructure.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleStatus> VehicleStatus { get; set; }
        public DbSet<BranchOffice> BranchOffices { get; set; }
        public DbSet<BranchOfficeZone> Zones { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<TransmissionType> TransmissionTypes { get; set; }
        public DbSet<VehicleReview> VehicleReviews { get; set; }
        public DbSet<VehicleDocument> VehicleDocuments { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicles");
                entity.HasKey(v => v.VehicleId);
                entity.Property(v => v.VehicleId)
                    .ValueGeneratedOnAdd();

                entity.HasOne(v => v.VehicleStatus)
                    .WithMany(vs => vs.Vehicles)
                    .HasForeignKey(v => v.VehicleStatusId);

                entity.HasOne(v => v.BranchOffice)
                    .WithMany(bo => bo.Vehicles)
                    .HasForeignKey(v => v.BranchOfficeId);                

                entity.HasOne(v => v.Category)
                    .WithMany(vc => vc.Vehicles)
                    .HasForeignKey(v => v.CategoryId);

                entity.HasOne(v => v.TransmissionType)
                    .WithMany(tt => tt.Vehicles)
                    .HasForeignKey(v => v.TransmissionTypeId);

                entity.HasMany(v => v.Reviews)
                    .WithOne(vr => vr.Vehicle)
                    .HasForeignKey(vr => vr.VehicleId);                

                entity.HasMany(v => v.Documents)
                    .WithOne(vd => vd.Vehicle)
                    .HasForeignKey(vd => vd.VehicleId);

                entity.Property(v => v.Brand)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(v => v.Model)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(v => v.LicensePlate)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(v => v.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(v => v.Price)
                    .IsRequired()
                    .HasColumnType("decimal(10,2)");

                entity.Property(v => v.SeatingCapacity)
                    .IsRequired();

                entity.Property(v => v.Year)
                    .IsRequired();
            });

            modelBuilder.Entity<VehicleStatus>(entity =>
            {
                entity.ToTable("VehicleStatus");
                entity.HasKey(vs => vs.Id);
                entity.Property(vs => vs.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(vs => vs.Name)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<BranchOffice>(entity =>
            {
                entity.ToTable("BranchOffices");
                entity.HasKey(bo => bo.BranchOfficeId);
                entity.Property(bo => bo.BranchOfficeId)
                    .ValueGeneratedOnAdd();

                entity.Property(bo => bo.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(bo => bo.Address)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(bo => bo.Phone)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(bo => bo.Hours)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(bo => bo.Latitude)
                    .IsRequired()
                    .HasColumnType("decimal(9,6)");

                entity.Property(bo => bo.Longitude)
                    .IsRequired()
                    .HasColumnType("decimal(9,6)");

                entity.Property(bo => bo.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(bo => bo.PostalCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(bo => bo.Province)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(bo => bo.LocationReference)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(bo => bo.Zone)
                    .WithMany(z => z.BranchOffices)
                    .HasForeignKey(bo => bo.BranchOfficeZoneId)
                    .OnDelete(DeleteBehavior.Restrict); 
            });

            modelBuilder.Entity<VehicleCategory>(entity =>
            {
                entity.ToTable("VehicleCategories");
                entity.HasKey(vc => vc.Id);
                entity.Property(vc => vc.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(vc => vc.Name)
                    .HasMaxLength(25)
                    .IsRequired();
                    

                entity.Property(vc => vc.Description)
                    .HasColumnType("varchar(max)")
                    .HasMaxLength(255)
                    .IsRequired();                    
            });

            modelBuilder.Entity<TransmissionType>(entity =>
            {
                entity.ToTable("TransmissionTypes");
                entity.HasKey(tt => tt.Id);
                entity.Property(tt => tt.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(tt => tt.Name)
                    .HasMaxLength(25)
                    .IsRequired();
            });

            modelBuilder.Entity<VehicleReview>(entity =>
            {
                entity.ToTable("VehicleReviews");
                entity.HasKey(vr => vr.ReviewId);                

                entity.Property(vr => vr.Comment)
                    .HasColumnType("varchar(max)")                    
                    .IsRequired(false);

                entity.Property(vr => vr.Rating)
                    .IsRequired();
                    
                entity.Property(vr => vr.CreatedAt)
                    .IsRequired()
                    .HasColumnType("datetime");

            });

            modelBuilder.Entity<VehicleDocument>(entity =>
            {
                entity.ToTable("VehicleDocuments");
                entity.HasKey(vd => vd.DocumentId);
                
                entity.Property(vd => vd.Url)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(vd => vd.DocType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(vd => vd.UploadDate)
                    .IsRequired()
                    .HasColumnType("datetime");
            });


            // Cargar datos predeterminados
            VehicleStatusSeed.Seed(modelBuilder);
            TransmissionTypeSeed.Seed(modelBuilder);
            VehicleCategorySeed.Seed(modelBuilder);
            BranchOfficeZoneSeed.Seed(modelBuilder);
            BranchOfficeSeed.Seed(modelBuilder);            

        }
    }
}

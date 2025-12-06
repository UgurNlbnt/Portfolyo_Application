using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AkademiQPortfolio.Data;

namespace OrnekDbContext
{
    public partial class portfolyoDbContext : DbContext
    {
        public portfolyoDbContext()
        {
        }

        public portfolyoDbContext(DbContextOptions<portfolyoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutMeTable> AboutMeTables { get; set; } = null!;
        public virtual DbSet<AwardTable> AwardTables { get; set; } = null!;
        public virtual DbSet<CatagoryTable> CatagoryTables { get; set; } = null!;
        public virtual DbSet<ContactInfoTable> ContactInfoTables { get; set; } = null!;
        public virtual DbSet<EducationTable> EducationTables { get; set; } = null!;
        public virtual DbSet<HomePage> HomePages { get; set; } = null!;
        public virtual DbSet<LatestNewTable> LatestNewTables { get; set; } = null!;
        public virtual DbSet<MessageTable> MessageTables { get; set; } = null!;
        public virtual DbSet<ProjectTable> ProjectTables { get; set; } = null!;
        public virtual DbSet<ServiceDetailTable> ServiceDetailTables { get; set; } = null!;
        public virtual DbSet<ServiceTable> ServiceTables { get; set; } = null!;
        public virtual DbSet<SkillTable> SkillTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NFEPLMA\\SQLEXPRESS;Database=portfolyoDb;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutMeTable>(entity =>
            {
                entity.HasKey(e => e.AboutId);

                entity.ToTable("AboutMeTable");

                entity.Property(e => e.AboutId).HasColumnName("AboutID");

                entity.Property(e => e.Cvpath)
                    .HasMaxLength(1000)
                    .HasColumnName("CVPath");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImagePath).HasMaxLength(1000);

                entity.Property(e => e.NameSurname).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<AwardTable>(entity =>
            {
                entity.HasKey(e => e.AwardId);

                entity.ToTable("AwardTable");

                entity.Property(e => e.AwardId).HasColumnName("AwardID");

                entity.Property(e => e.AboutId).HasColumnName("AboutID");

                entity.Property(e => e.AwardDescription).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.HasOne(d => d.About)
                    .WithMany(p => p.AwardTables)
                    .HasForeignKey(d => d.AboutId)
                    .HasConstraintName("FK_AwardTable_AboutMeTable");
            });

            modelBuilder.Entity<CatagoryTable>(entity =>
            {
                entity.HasKey(e => e.CatagoryId);

                entity.ToTable("CatagoryTable");

                entity.Property(e => e.CatagoryId).HasColumnName("CatagoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactInfoTable>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("ContactInfoTable");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.AdressIcon).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FirstMail).HasMaxLength(500);

                entity.Property(e => e.FirstPhone).HasMaxLength(500);

                entity.Property(e => e.MailIcon).HasMaxLength(500);

                entity.Property(e => e.PhoneIcon).HasMaxLength(500);

                entity.Property(e => e.SecondMail).HasMaxLength(500);

                entity.Property(e => e.SecondPhone).HasMaxLength(500);
            });

            modelBuilder.Entity<EducationTable>(entity =>
            {
                entity.HasKey(e => e.EducationId);

                entity.ToTable("EducationTable");

                entity.Property(e => e.EducationId).HasColumnName("EducationID");

                entity.Property(e => e.AboutId).HasColumnName("AboutID");

                entity.Property(e => e.SchoolName).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Years).HasMaxLength(100);

                entity.HasOne(d => d.About)
                    .WithMany(p => p.EducationTables)
                    .HasForeignKey(d => d.AboutId)
                    .HasConstraintName("FK_EducationTable_AboutMeTable");
            });

            modelBuilder.Entity<HomePage>(entity =>
            {
                entity.HasKey(e => e.HomeId)
                    .HasName("PK__HomePage__105D642242675855");

                entity.ToTable("HomePage");

                entity.Property(e => e.HomeId).HasColumnName("HomeID");

                entity.Property(e => e.ImagePath).HasMaxLength(200);

                entity.Property(e => e.NameSurname).HasMaxLength(100);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<LatestNewTable>(entity =>
            {
                entity.HasKey(e => e.LatestId);

                entity.ToTable("LatestNewTable");

                entity.Property(e => e.LatestId).HasColumnName("LatestID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImagePath).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);
            });

            modelBuilder.Entity<MessageTable>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("MessageTable");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Description).HasMaxLength(1500);

                entity.Property(e => e.SenderEmailAdress).HasMaxLength(500);

                entity.Property(e => e.SenderNameSurname).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(500);
            });

            modelBuilder.Entity<ProjectTable>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.ToTable("ProjectTable");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.ProjectName).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProjectTables)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_ProjectTable_CatagoryTable");
            });

            modelBuilder.Entity<ServiceDetailTable>(entity =>
            {
                entity.HasKey(e => e.ServiceDetailId);

                entity.ToTable("ServiceDetailTable");

                entity.Property(e => e.ServiceDetailId).HasColumnName("ServiceDetailID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Icon).HasMaxLength(500);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceDetailTables)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_ServiceDetailTable_ServiceTable");
            });

            modelBuilder.Entity<ServiceTable>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.ToTable("ServiceTable");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Description).HasMaxLength(1000);
            });

            modelBuilder.Entity<SkillTable>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("SkillTable");

                entity.Property(e => e.SkillId).HasColumnName("SkillID");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

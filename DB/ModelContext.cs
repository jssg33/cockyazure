using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EntityFrameworkCore.Jet;

namespace WEBAPI.MODELSACCESS;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
        //this.Configuration.AutoDetectChangesEnabled = false;
    }


    public virtual DbSet<Student> Students { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseJet("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\stritzj\\Documents\\DatabaseTest2.accdb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PrimaryKey");
            //entity.HasIndex(e => e.StudentId, "Student ID").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("counter")
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CountryRegion)
                .HasMaxLength(50)
                .HasColumnName("Country/Region");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of Birth");
            entity.Property(e => e.EMailAddress)
                .HasMaxLength(50)
                .HasColumnName("E-mail Address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.HomePhone)
                .HasMaxLength(25)
                .HasColumnName("Home Phone");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(255)
                .HasColumnName("ID Number");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
            entity.Property(e => e.Level).HasMaxLength(30);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(25)
                .HasColumnName("Mobile Phone");
            entity.Property(e => e.Room).HasMaxLength(20);
            entity.Property(e => e.StateProvince)
                .HasMaxLength(50)
                .HasColumnName("State/Province");
            entity.Property(e => e.StudentId)
                .HasMaxLength(20)
                .HasColumnName("Student ID");
            entity.Property(e => e.WebPage).HasColumnName("Web Page");
            entity.Property(e => e.ZipPostalCode)
                .HasMaxLength(15)
                .HasColumnName("ZIP/Postal Code");
        });


        OnModelCreatingPartial(modelBuilder);
        modelBuilder.Entity<Student>().Property(s => s.Id).ValueGeneratedOnAdd(); // Configure auto-increment
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

 }

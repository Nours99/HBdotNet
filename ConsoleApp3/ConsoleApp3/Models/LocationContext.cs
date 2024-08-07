﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

public partial class LocationContext : DbContext
{
    public LocationContext()
    {
    }

    public LocationContext(DbContextOptions<LocationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Marque> Marques { get; set; }

    public virtual DbSet<Vehicule> Vehicules { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LOCATION_VEHICULE;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CATEGORI__3214EC271AE151E6");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CLIENT__3214EC27552A1E35");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LOCATION__3214EC27833B847E");

            entity.HasOne(d => d.IdClientNavigation).WithMany(p => p.Locations).HasConstraintName("FK__LOCATION__ID_CLI__30F848ED");

            entity.HasOne(d => d.IdVehiculeNavigation).WithMany(p => p.Locations).HasConstraintName("FK__LOCATION__ID_VEH__31EC6D26");
        });

        modelBuilder.Entity<Marque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MARQUE__3214EC272D86AD4C");
        });

        modelBuilder.Entity<Vehicule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VEHICULE__3214EC27CF77D1D7");

            entity.HasOne(d => d.IdCategorieNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK__VEHICULE__ID_CAT__2E1BDC42");

            entity.HasOne(d => d.IdMarqueNavigation).WithMany(p => p.Vehicules).HasConstraintName("FK__VEHICULE__ID_MAR__2D27B809");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
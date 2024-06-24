﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

[Table("LOCATION")]
public partial class Location
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ID_CLIENT")]
    public int? IdClient { get; set; }

    [Column("ID_VEHICULE")]
    public int? IdVehicule { get; set; }

    [Column("NB_KM")]
    public int NbKm { get; set; }

    [Column("DATE_DEBUT")]
    public DateOnly DateDebut { get; set; }

    [Column("DATE_FIN")]
    public DateOnly? DateFin { get; set; }

    [ForeignKey("IdClient")]
    [InverseProperty("Locations")]
    public virtual Client IdClientNavigation { get; set; }

    [ForeignKey("IdVehicule")]
    [InverseProperty("Locations")]
    public virtual Vehicule IdVehiculeNavigation { get; set; }
}
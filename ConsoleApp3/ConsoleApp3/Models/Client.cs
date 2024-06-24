﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

[Table("CLIENT")]
public partial class Client
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("NOM")]
    [StringLength(50)]
    public string Nom { get; set; }

    [Required]
    [Column("PRENOM")]
    [StringLength(50)]
    public string Prenom { get; set; }

    [Column("DATE_NAISSANCE")]
    public DateOnly DateNaissance { get; set; }

    [Column("ADRESSE")]
    [StringLength(150)]
    public string Adresse { get; set; }

    [Column("CODE_POSTAL")]
    [StringLength(15)]
    public string CodePostal { get; set; }

    [Column("VILLE")]
    [StringLength(50)]
    public string Ville { get; set; }

    [InverseProperty("IdClientNavigation")]
    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
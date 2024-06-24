﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

[Table("CATEGORIE")]
[Index("Libelle", Name = "UQ__CATEGORI__64586F3A9C4A7709", IsUnique = true)]
public partial class Categorie
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("LIBELLE")]
    [StringLength(100)]
    public string Libelle { get; set; }

    [Column("PRIX_KM")]
    public int PrixKm { get; set; }

    [InverseProperty("IdCategorieNavigation")]
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Models;

[Table("MARQUE")]
[Index("Nom", Name = "UQ__MARQUE__C7DEF3F6DC681D22", IsUnique = true)]
public partial class Marque
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Required]
    [Column("NOM")]
    [StringLength(50)]
    public string Nom { get; set; }

    [InverseProperty("IdMarqueNavigation")]
    public virtual ICollection<Vehicule> Vehicules { get; set; } = new List<Vehicule>();
}
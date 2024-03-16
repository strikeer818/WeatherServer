﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CountryModel;

[Table("City")]
public partial class City
{
    [Key]
    [Column("CityID")]
    public int CityId { get; set; }
    public required string Name { get; set; }
    public int Population { get; set; }

    [Column("lattitude", TypeName = "numeric(18, 4)")]
    public decimal Lattitude { get; set; }

    [Column("longitude")]
    [StringLength(10)]
    //public string Longitude { get; set; } = NULL;
    public decimal Longitude { get; set; } 

    [Column("CountryID")]
    public int CountryId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Cities")]
    public virtual Country Country { get; set; } = null!;
}

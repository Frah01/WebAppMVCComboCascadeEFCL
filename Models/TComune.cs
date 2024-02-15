﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebAppMVCComboCascadeEF.Models;

[Table("T_Comune")]
public partial class TComune
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Display(Name = "Nome Comune")]
    public string Nome { get; set; }

    public int? IdProvincia { get; set; }

    [Display(Name = "Num. Abitanti")]
    public int? NumAbitanti { get; set; }

    [ForeignKey("IdProvincia")]
    [InverseProperty("TComunes")]
    [Display(Name = "Provincia di Appartenenza")]

    public virtual TProvincium IdProvinciaNavigation { get; set; }
}
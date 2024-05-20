using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EnityFramework.DataAccess1;

public partial class Product
{
    [Key]
    [NotNull]
    [Required]
    public int Id { get; set; }

    [MaxLength(50)]
    public string? Name { get; set; }

    [Required]
    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}

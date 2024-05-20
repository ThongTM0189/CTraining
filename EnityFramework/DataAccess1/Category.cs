using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EnityFramework.DataAccess1;

public partial class Category
{
    [Key]
    [NotNull]
    [Required]
    public int Id { get; set; }

    [MaxLength(50)]
    public string? Name { get; set; }

    public int? age { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}

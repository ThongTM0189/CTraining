using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Product
    {
        [Key]
        [NotNull]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? name { get; set;}
        [NotNull]
        public int? categoryId { get; set;}
        public virtual Category Category { get; set; } = new Category();
    }
}

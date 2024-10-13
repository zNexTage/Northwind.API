using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Required]
        [Column("TerritoryId")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; } = default!;

        [Required]
        [ForeignKey(nameof(Region))]
        public Region Region { get; set; } = default!;
    }
}

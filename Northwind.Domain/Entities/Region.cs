using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    public class Region
    {
        [Required]
        [Column("RegionId")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("RegionDescription")]
        public int Description { get; set; }
    }
}

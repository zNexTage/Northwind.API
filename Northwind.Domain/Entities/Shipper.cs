using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("Shippers")]
    public class Shipper
    {
        [Column("ShipperID")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; } = default!;

        [MaxLength(24)]
        public string Phone { get; set; } = default!;

    }
}

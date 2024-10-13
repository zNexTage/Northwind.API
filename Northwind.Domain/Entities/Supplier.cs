using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Domain.Entities
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Column("SupplierId")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; } = default!;

        [Required]
        [MaxLength(30)]
        public string ContactName { get; set; } = default!;

        [Required]
        [MaxLength(30)]
        public string ContactTitle { get; set; } = default!;

        [Required]
        [MaxLength(60)]
        public string Address { get; set; } = default!;

        [Required]
        [MaxLength(15)]
        public string City { get; set; } = default!;

        [Required]
        [MaxLength(15)]
        public string Region { get; set; } = default!;

        [Required]
        [MaxLength(10)]
        public string PostalCode { get; set; } = default!;

        [Required]
        [MaxLength(15)]
        public string Country { get; set; } = default!;

        [Required]
        [MaxLength(24)]
        public string Phone { get; set; } = default!;

        [Required]
        [MaxLength(24)]
        public string Fax { get; set; } = default!;

        [Required]
        [MaxLength(1073741823)]
        public string HomePage { get; set; } = default!;

    }
}

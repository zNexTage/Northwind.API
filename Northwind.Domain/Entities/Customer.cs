using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        [Column("CustomerID")]
        public string Id { get; set; } = default!;

        [Required]
        [MaxLength(40)]
        public string CompanyName { get; set; } = default!;

        [MaxLength(30)]
        public string ContactName { get; set; } = default!;

        [MaxLength(30)]
        public string ContactTitle { get; set; } = default!;

        [MaxLength(60)]
        public string Address { get; set; } = default!;

        [MaxLength(15)]
        public string City { get; set; } = default!;

        [MaxLength(15)]
        public string Region { get; set; } = default!;

        [MaxLength(10)]
        public string PostalCode { get; set; } = default!;

        [MaxLength(15)]
        public string Country { get; set; } = default!;

        [MaxLength(24)]
        public string Phone { get; set; } = default!;

        [MaxLength(24)]
        public string Fax { get; set; } = default!;
    }
}

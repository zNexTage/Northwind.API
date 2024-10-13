using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Required]
        [Key]
        [Column("EmployeeID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string LastName { get; set; } = default!;

        [Required]
        [MaxLength(10)]
        public string FirstName { get; set; } = default!;

        [Required]
        [MaxLength(30)]
        public string Title { get; set; } = default!;

        [Required]
        [MaxLength(25)]
        public string TitleOfCourtesy { get; set; } = default!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

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
        public string HomePhone { get; set; } = default!;

        [Required]
        [MaxLength(4)]
        public string Extension { get; set; } = default!;

        [Required]
        public byte[] Photo { get; set; } = default!;

        [Required]
        public ICollection<Territory> Territories { get; set; }
    }
}

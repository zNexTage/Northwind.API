using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Domain.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Column("CategoryID")]
        public int Id { get; set; }

        [MaxLength(15)]
        [Column("CategoryName")]
        [Required]
        public string Name { get; set; } = default!;

        [Required]
        public string Description { get; set; } = default!;

        [DataType(DataType.Upload)]
        [Required]
        public byte[] Picture { get;set; } = default!;
    }
}

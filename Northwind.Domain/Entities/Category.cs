using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Domain.Entities
{
    public class Category
    {
        [Key]
        [Column("CategoryID")]
        public int Id { get; set; }

        [MaxLength(15)]
        [Column("CategoryName")]
        [Required]
        public string Name { get; set; }

        [MaxLength(1073741823)]
        [Required]
        public string Description { get; set; }

        [DataType(DataType.Upload)]
        [Required]
        public byte[] Picture { get;set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Northwind.Domain.Entities
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; } = default!;

        //public Supplier Supplier { get; set; } TODO: Criar entidade Supplier

        [Required]
        public Category Category { get; set; } = default!;

        [Required]
        [MaxLength(20)]
        public string QuantityPerUnit { get; set; } = default!;

        [Required]
        [DataType(DataType.Currency)]
        public decimal UnitPrice{ get; set; }

        [Required]
        public int UnitsInStock { get; set; }

        [Required]
        public int UnitsOnOrder { get; set; }

        [Required]
        public int ReorderLevel { get; set; }
                
        public bool Discontinued { get; set; } = false;
    }
}

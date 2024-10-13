﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Column("OrderID")]
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        [Required]
        public Product Product { get; set; } = default!;

        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public float Discount { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Domain.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Column("OrderID")]
        public int Id { get; set; }

        [Column("CustomerID")]
        [ForeignKey(nameof(Customer))]
        public Customer Customer { get; set; }

        [Column("EmployeeID")]
        [ForeignKey(nameof(Employee))]
        public Employee Employee { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ShippedDate { get; set; }

        [Column("ShipVia")]
        [ForeignKey(nameof(Shipper))]
        public ICollection<Shipper> Shippers { get; set; }

        [Column("Freight")]
        [DataType(DataType.Currency)]
        public decimal Freight { get; set; }

        [MaxLength(40)]
        public string ShipName { get; set; }

        [MaxLength(60)]
        public string ShipAddress { get; set; }

        [MaxLength(15)]
        public string ShipCity { get; set; }

        [MaxLength(15)]
        public string ShipRegion { get; set; }

        [MaxLength(10)]
        public string ShipPostalCode { get; set; }

        [MaxLength(15)]
        public string ShipCountry { get; set; }

    }
}

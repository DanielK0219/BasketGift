using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketGift.DataAccess.Data
{
    [Table("bg_orders")]
    public class OrdersTable
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty; // FK to AspNetUsers.Id

        [Column(TypeName = "decimal(10,2)")]
        public decimal TotalPrice { get; set; }

        public string ShippingAddress { get; set; } = string.Empty;

        public string? AdditionalInfo { get; set; }

        public string Status { get; set; } = "pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItemsTable> OrderItems { get; set; } = new List<OrderItemsTable>();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketGift.DataAccess.Data
{
    [Table("bg_order_items")]
    public class OrderItemsTable
    {
        public int Id { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public OrdersTable? Order { get; set; }

        [ForeignKey("Basket")]
        public int BasketId { get; set; }
        public ItemsTable? Basket { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal UnitPrice { get; set; }
    }
}

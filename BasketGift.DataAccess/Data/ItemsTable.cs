using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketGift.DataAccess.Data
{
    [Table("bg_tems")]
    public class ItemsTable
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public bool IsCustomizable { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public CategoriesTable? Category { get; set; }

        public ICollection<OrderItemsTable> OrderItems { get; set; } = new List<OrderItemsTable>();
    }
}

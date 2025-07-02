using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketGift.DataAccess.Data
{
    [Table("bg_categories")]
    public class CategoriesTable
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<ItemsTable> Items { get; set; } = new List<ItemsTable>();
    }
}

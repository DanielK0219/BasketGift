using BasketGift.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace BasketGift.DataAccess.Contexts
{
    public class BGDbContext : DbContext
    {
        public BGDbContext(DbContextOptions<BGDbContext> options)
            : base(options) { }

        public DbSet<CategoriesTable> CategoriesTables => Set<CategoriesTable>();
        public DbSet<ItemsTable> ItemsTables => Set<ItemsTable>();
        public DbSet<OrdersTable> OrdersTables => Set<OrdersTable>();
        public DbSet<OrderItemsTable> OrderItemsTables => Set<OrderItemsTable>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Items.Models
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Item> Items { get; set; }

        public DbSet<ItemColor> ItemColors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
    .HasKey(o => o.ID);
            modelBuilder.Entity<Item>()
    .Property(o => o.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<Color>()
    .Property(o => o.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<ItemColor>()
                .HasKey(bc => new { bc.ItemId, bc.ColorId });
            modelBuilder.Entity<ItemColor>()
                .HasOne(bc => bc.Item)
                .WithMany(b => b.ItemColors)
                .HasForeignKey(bc => bc.ItemId);
            modelBuilder.Entity<ItemColor>()
                .HasOne(bc => bc.Color)
                .WithMany(c => c.ColorItems)
                .HasForeignKey(bc => bc.ColorId);
        }
    }
}


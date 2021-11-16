using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contexts
{
    public class ShopBridgeContext : DbContext
    {
        public ShopBridgeContext() : base()
        {
            Database.SetInitializer<ShopBridgeContext>(new CreateDatabaseIfNotExists<ShopBridgeContext>());
        }

        public DbSet<Product> ProductSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(x => x.ProductId);
            modelBuilder.Entity<Product>().Property(x => x.ProductId).HasColumnName("ProductId")
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Product>().Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(x => x.Price)
                .HasColumnName("Price");
            modelBuilder.Entity<Product>().Property(x => x.StockCount)
                .HasColumnName("StockCount");
        }
    }
}

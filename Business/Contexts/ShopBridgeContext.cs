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
        public ShopBridgeContext() : base("name=ShopBridge")
        {
            Database.SetInitializer(new CustomDBInitializer());
        }

        public DbSet<Product> ProductSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

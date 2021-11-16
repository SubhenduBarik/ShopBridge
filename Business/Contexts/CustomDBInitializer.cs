using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Business.Contexts
{
    public class CustomDBInitializer : CreateDatabaseIfNotExists<ShopBridgeContext>
    {
        protected override void Seed(ShopBridgeContext context)
        {
            List<Product> initializeProducts = new List<Product>();
            initializeProducts.Add(new Product() {
                Name="Chocolate Chips", 
                Description="Filled with chocolate chips", Price=5, StockCount=25});
            initializeProducts.Add(new Product() {
                Name="Fortune Cookies", 
                Description="Filled with good wishes", Price=12, StockCount=15});
            initializeProducts.Add(new Product() {
                Name="Macaroons", 
                Description="Soft and colorful", Price=5, StockCount=25});
            initializeProducts.Add(new Product() {
                Name="Oreo", 
                Description="Ooooreoooo", Price=5, StockCount=6});
            initializeProducts.Add(new Product() {
                Name="Red Velvet", 
                Description="So Velvety", Price=8, StockCount=25});
            initializeProducts.Add(new Product() {
                Name="Fruits and nuts", 
                Description="The richness of nutrition", Price=12, StockCount=45});

            context.ProductSet.AddRange(initializeProducts);

            base.Seed(context);
        }
    }
}

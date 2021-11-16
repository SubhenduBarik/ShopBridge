using Business.Contexts;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var products = entityContext.ProductSet.ToList();
                return products;
            }
        }
        
        public Product GetProduct(int productId)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var product = entityContext.ProductSet.First(x => x.ProductId == productId);
                return product;
            }
        }

        public void AddProduct(Product product)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                entityContext.ProductSet.Add(product);
                entityContext.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var existingProduct = entityContext.ProductSet.FirstOrDefault(x => x.ProductId == product.ProductId);

                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.StockCount = product.StockCount;

                entityContext.SaveChanges();
            }
        }

        public void RemoveProduct(int productId)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var existingProduct = entityContext.ProductSet.FirstOrDefault(x => x.ProductId == productId);
                entityContext.ProductSet.Remove(existingProduct);
                entityContext.SaveChanges();
            }
        }
    }
}

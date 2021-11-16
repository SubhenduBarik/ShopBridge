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

        public Product AddProduct(Product product)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var addedProd = entityContext.ProductSet.Add(product);
                entityContext.SaveChanges();
                return addedProd;
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

        public Product RemoveProduct(int productId)
        {
            using (var entityContext = new ShopBridgeContext())
            {
                var existingProduct = entityContext.ProductSet.FirstOrDefault(x => x.ProductId == productId);
                var prod = entityContext.ProductSet.Remove(existingProduct);
                entityContext.SaveChanges();
                return prod;
            }
        }
    }
}

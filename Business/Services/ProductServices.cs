﻿using Business.Entities;
using Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ProductServices : IProductServices
    {
        private IProductRepository _productRepo = null;

        public ProductServices()
        {
            _productRepo = new Business.Repository.ProductRepository();
        }

        public void AddProduct(Product product)
        {
            _productRepo.AddProduct(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productRepo.GetAllProducts();
        }

        public Product GetProduct(int productId)
        {
            return _productRepo.GetProduct(productId);
        }

        public void RemoveProduct(int productId)
        {
            _productRepo.RemoveProduct(productId);
        }

        public void UpdateProduct(Product product)
        {
            _productRepo.UpdateProduct(product);
        }
    }
}

using Business.Entities;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopBridgeApi.Controllers
{
    public class ProductController : ApiController
    {
        private IProductServices _productServices = null;

        public ProductController()
        {
            _productServices = new Business.Services.ProductServices();
        }

        [HttpPost]
        public void AddProduct(Product product)
        {
            _productServices.AddProduct(product);
        }

        [HttpGet]
        public List<Product> GetAllProducts()
        {
            return _productServices.GetAllProducts();
        }

        [HttpGet]
        public Product GetProduct(int productId)
        {
            return _productServices.GetProduct(productId);
        }

        [HttpGet]
        public void RemoveProduct(int productId)
        {
            _productServices.RemoveProduct(productId);
        }

        [HttpPost]
        public void UpdateProduct(Product product)
        {
            _productServices.UpdateProduct(product);
        }
    }
}
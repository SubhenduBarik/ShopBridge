using Business.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace ShopBridge.ApiWrappers
{
    public static class ProductApiWrapper
    {
        readonly static string baseAddr = "https://localhost:44370/api/Product/";
        public static List<Product> GetAllProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                string request = "GetAllProducts";
                var response = client.GetAsync(request).Result;

                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsAsync<List<Product>>().Result;

                return result;
            }
        }

        public static Product GetProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                string request = "GetProduct?productId=" + id;
                var response = client.GetAsync(request).Result;

                response.EnsureSuccessStatusCode();
                var result = response.Content.ReadAsAsync<Product>().Result;

                return result;
            }
        }

        public static Product DeleteProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                string request = "RemoveProduct?productId=" + id;
                var response = client.GetAsync(request).Result;

                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsAsync<Product>().Result;
            }
        }

        public static void UpdateProduct(Product product)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                string request = "UpdateProduct";
                var response = client.PostAsJsonAsync<Product>(request, product).Result;

                response.EnsureSuccessStatusCode();
            }
        }

        public static Product AddProduct(Product product)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddr);
                string request = "AddProduct";
                var response = client.PostAsJsonAsync<Product>(request, product).Result;

                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsAsync<Product>().Result;
            }
        }
    }
}
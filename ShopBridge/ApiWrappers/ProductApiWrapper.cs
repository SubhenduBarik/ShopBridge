using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

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
    }
}
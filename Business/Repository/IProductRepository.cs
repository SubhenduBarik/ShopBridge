using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public interface IProductRepository
    {
         List<Product> GetAllProducts();

         Product GetProduct(int productId);

         void AddProduct(Product product);

         void UpdateProduct(Product product);

         void RemoveProduct(int productId);
    }
}

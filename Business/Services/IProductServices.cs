using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();

        Product GetProduct(int productId);

        Product AddProduct(Product product);

        void UpdateProduct(Product product);

        Product RemoveProduct(int productId);
    }
}

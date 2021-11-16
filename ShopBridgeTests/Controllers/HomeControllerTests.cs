using Business.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShopBridge.ApiWrappers;

namespace ShopBridge.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            var newProd = new Product()
            {
                Name = "testCookie",
                Description = "testing",
                Price = 12,
                StockCount = 1
            };
            var controller = new ShopBridgeApi.Controllers.ProductController();       
            var addedProd = controller.AddProduct(newProd);
            Assert.AreEqual(newProd.Name, controller.GetProduct(addedProd.ProductId).Name);

            //clean
            controller.RemoveProduct(newProd.ProductId);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            var newProd = new Product()
            {
                Name = "testCookie",
                Description = "testing",
                Price = 12,
                StockCount = 1
            };

            var controller = new ShopBridgeApi.Controllers.ProductController();
            var addedProd = controller.AddProduct(newProd);
            var deletedProd = controller.RemoveProduct(newProd.ProductId);
            Assert.AreEqual(addedProd.Name, deletedProd.Name);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            var newProd = new Product()
            {
                Name = "testCookie",
                Description = "testing",
                Price = 12,
                StockCount = 1
            };

            var controller = new ShopBridgeApi.Controllers.ProductController();
            var addedProd = controller.AddProduct(newProd);
            //update
            addedProd.Name = "updateTest";
            controller.UpdateProduct(addedProd);
            Assert.AreEqual(controller.GetProduct(addedProd.ProductId).Name, "updateTest");
            //clean
            var deletedProd = controller.RemoveProduct(newProd.ProductId);
        }
    }
}
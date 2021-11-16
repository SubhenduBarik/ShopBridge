using Business.Entities;
using ShopBridge.ApiWrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBridge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var prods = ProductApiWrapper.GetAllProducts();
            return View(prods);
        }

        public ActionResult Delete(int id)
        {
            ProductApiWrapper.DeleteProduct(id);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Update(int id)
        {
            var prod = ProductApiWrapper.GetProduct(id);
            return View(prod);
        }
        
        [HttpPost]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductApiWrapper.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }
        
        [HttpGet]
        public ActionResult Add()
        {
            var prod = new Product();
            return View(prod);
        }
        
        [HttpPost]
        public ActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductApiWrapper.AddProduct(product);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
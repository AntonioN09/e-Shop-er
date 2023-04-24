using EShop.Data;
using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext db;
        public ProductsController(ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()

        {
            var products = from product in db.Products
                           orderby product.Name
                           select product;
            ViewBag.Products = products;


            return View();
        }

        public ActionResult Show(int Id)
        {
            Product product = db.Products.Find(Id);
            ViewBag.Student = product;
            return View();
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(Product p)
        {
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View();
            }
        }
        public IActionResult Edit(int Id)
        {
            Product product = db.Products.Find(Id);
            ViewBag.Product = product;
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int Id, Product requestProduct)
        {
            Product product = db.Products.Find(Id);
            try
            {
                product.Name = requestProduct.Name;
                product.Description = requestProduct.Description;
                product.Price = requestProduct.Price;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Edit", product.Id);
            }
        }
       
        
    }
}

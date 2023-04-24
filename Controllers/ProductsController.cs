using EShop.Data;
using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EShop.Controllers
{
    public class ProductsController : Controller
    {
        // Bind with the database: dependency injection
        private readonly ApplicationDbContext db;

        // Must initialize everything in the constructor
        public ProductsController(ApplicationDbContext context)
        {
            db = context;
        }

        // The view of our main page
        public IActionResult Index()

        {
            // get all products
            var products = from product in db.Products
                           orderby product.Name
                           select product;
            ViewBag.Products = products;


            return View();
        }

        //find product by id
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

        //create a new product
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

        // modify a product by id
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
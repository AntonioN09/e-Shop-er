using EShop.Data;
using EShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult New(String Name, String Description, int Price)
        {
            try
            {
                Product p = new Product();
                p.Name = Name;
                p.Description = Description;
                p.Price = Price;
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nMessage ---\n{0}", ex.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", ex.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", ex.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", ex.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", ex.TargetSite);
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
       
      /*  public ActionResult GetProductsInCart(int CartId)
        {
            var applicationDbContext = db.Products.Include(p => p.Cart == CartId);
            return View(await applicationDbContext.ToListAsync());
        }*/
    }
}
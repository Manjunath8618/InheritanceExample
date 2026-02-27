using DemoProject.DataConnection;
using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class ProductsController : Controller
    {
        ProductContext db = new ProductContext();

        public ViewResult AllProducts()
        {
            return View(db.Products.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                  return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product id Required");
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product Not Found");
            }
            return View(product);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            db.Products.Add(product);
            //TryUpdateModel(product);
            db.SaveChanges();

            return RedirectToAction("AllProducts");
        }
        //[HttpPost]
        //public ActionResult Create(FormCollection formCollection)
        //{
        //    Product product = new Product();
        //    product.ProductName = formCollection["ProductName"];
        //    product.Price = Convert.ToDecimal(formCollection["Price"]);
        //    db.Products.Add(product);
        //    db.SaveChanges();

        //    return RedirectToAction("AllProducts");
        //}
        
        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Product id requied");
            }
            Product product = db.Products.Find(id);
           if(product==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product Not Found");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Product product = db.Products.Find(id);
            UpdateModel(product);
            db.SaveChanges();
            return RedirectToAction("AllProducts");
        }
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Id is Requied");
            }
            Product product = db.Products.Find(id);
            if(product==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Product Not Found");
            }
            return View(product);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("AllProducts");
        }
    }
}
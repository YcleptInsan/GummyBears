using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBear.Models;
using Microsoft.EntityFrameworkCore;


namespace GummyBear.Controllers
{
    public class ProductsController : Controller
    {
        private GummyBearContext db = new GummyBearContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisItem = db.Products.FirstOrDefault(items => items.ProductId == id);
            return View(thisItem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product item)
        {
            db.Products.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisItem = db.Products.FirstOrDefault(items => items.ProductId == id);
            return View(thisItem);
        }

        [HttpPost]
        public IActionResult Edit(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisItem = db.Products.FirstOrDefault(items => items.ProductId == id);
            return View(thisItem);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisItem = db.Products.FirstOrDefault(items => items.ProductId == id);
            db.Products.Remove(thisItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

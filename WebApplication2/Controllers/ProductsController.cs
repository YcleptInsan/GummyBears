using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBear.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummyBear.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        private GummyBearContext db = new GummyBearContext();
        public IActionResult Index()
        {
            return View();
        }
    }
}

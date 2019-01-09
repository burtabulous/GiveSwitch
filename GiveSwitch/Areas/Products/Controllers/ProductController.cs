using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GiveSwitch.Areas.Products.Controllers
{
    [Area("Products")]
    [Route("products")]
    //[Route("")]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.productId = id;
            return View();
        }
    }
}
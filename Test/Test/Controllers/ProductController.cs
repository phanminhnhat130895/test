using Microsoft.AspNetCore.Mvc;
using Test.Data;
using Test.Models;

namespace Test.Controllers
{
    public class ProductController : Controller
    {
        private ProductDbContext _context;
        public ProductController(ProductDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(product);
            }
        }
    }
}

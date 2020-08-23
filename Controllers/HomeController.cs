using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using G151210078.Models;
using G151210078.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace G151210078.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

   
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index(string category , string brand, string categoryBrand)
        {
            List<string> categoryList = new List<string>();
            List<string> brandList = new List<string>();
            foreach (var items in _context.Products)
            {
                categoryList.Add(items.Category);
                brandList.Add(items.Brand);
            }
            IEnumerable<string> distinctCategories = categoryList.AsQueryable().Distinct();
            IEnumerable<string> distinctBrands = brandList.AsQueryable().Distinct();

            
            ViewBag.Brands = distinctBrands;
            ViewBag.Categories = distinctCategories;
            ViewBag.Brand = string.Format("{0}", brand);
            ViewBag.CategoryBrand = string.Format("{0}", categoryBrand);
            ViewBag.Category = string.Format("{0}", category);
            return View(await _context.Products.ToListAsync());
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> ProductDetail(int? DetailId, int modelId)
        {
            if (DetailId == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == DetailId);
            if (ModelState.IsValid)
            {

            }
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public async Task<IActionResult> OrderListAsync()
        {
            var order = await _context.Orders.ToListAsync();
            var products = await _context.Products.ToListAsync();
            List<int> orderList = new List<int>();
            List<int> orderIdList = new List<int>();
            Dictionary<int, List<Product>> productDict = new Dictionary<int, List<Product>>();
            List<Product> product = new List<Product>();
            foreach (var items in _context.Orders)
            {
                if (items.UserName == User.Identity.Name)
                {
                    orderIdList.Add(items.OrderId);
                }
            }
            IEnumerable<int> distinctOrderId = orderIdList.AsQueryable().Distinct();
            foreach (var ordId in distinctOrderId)
            {
                foreach(var items in _context.Orders)
                {
                    if (items.OrderId == ordId)
                    {
                        orderList.Add(items.ProductId);
                    }
                }
                foreach(var item in orderList)
                {
                    foreach(var all in products)
                    {
                        if(item == all.ID)
                        {
                             product.Add(all);
                        }
                    }
                }
                productDict.Add(ordId, product);
                product = new List<Product>();
                orderList = new List<int>();
            }

            ViewBag.Product = productDict;
            return View();
        }

        public IActionResult OrderDetail(Dictionary<int, List<Product>> productDict)
        {
            var count = 0;
            foreach(var i in productDict)
            {
                ViewBag.total += productDict.Sum(item => item.Value[count].Price);
                count++;
            }
            ViewBag.OrderList = productDict;
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

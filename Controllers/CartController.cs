using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Claims;
using System.Threading.Tasks;
using G151210078.Data;
using G151210078.Models;
using G151210078.TagHelper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace G151210078.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private UserManager<IdentityUser> userManager;

        public CartController( ApplicationDbContext context, IWebHostEnvironment hostEnvironment, UserManager<IdentityUser> usrMgr)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
            userManager = usrMgr;
        }

        [Route("index")]
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.Product.Price * item.Quantity);
            return View();
        }

        [Route("buy/{id}")]
        public async Task<IActionResult> BuyAsync(int id)
        {
            Product productModel = new Product();
            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ID == id);
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                 
                cart.Add(new Item { Product = product, Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = isExist(id.ToString());
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = product, Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }

            return RedirectToAction("Index");
        }

        [Route("remove/{id}")]
        public IActionResult Remove(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");
        }
        

        public async Task<IActionResult> OrderCreateAsync()
        {

            Product productModel = new Product();
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            var order = await _context.Orders.ToListAsync();
            var idDetect = 0;
            foreach (var ord in order)
            {
                if (ord.OrderId > idDetect)
                {
                    idDetect = ord.OrderId;
                }
            }
            idDetect += 1;
            foreach (var item in cart)
            {
                
                var newOrder = new Order() {
                    ProductId = item.Product.ID,
                    UserName = User.Identity.Name,
                    OrderId = idDetect,
                };
                _context.Orders.Add(newOrder);
                await _context.SaveChangesAsync();
            }
            cart = null;
            return RedirectToAction("Index");
        }

        private int isExist(string id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

    }
}

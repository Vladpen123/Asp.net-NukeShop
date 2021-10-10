using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class OrderController : Controller
    {

        Cart cart;
        public OrderController(Cart cartService)
        {

            cart = cartService;
        }

        
        public IActionResult Checkout()
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Извините, Ваша корзина пуста!");
            }
            Order order = new Order() { Lines = cart.Lines };
            return View(order);
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {

            if (ModelState.IsValid)
            {
                cart.Clear();
                return RedirectToPage("/Completed", new { Id = order.Id });
            }
            else
                return View();
        }
    }
}

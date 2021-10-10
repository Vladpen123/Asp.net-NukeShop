using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Infrastructure;
using WebUI.Models;

namespace WebUI.Pages
{
    public class CartModel : PageModel
    {
        private readonly IGoodService goodService;

        public CartModel(IGoodService goodService, Cart cartService)
        {
            this.goodService = goodService;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";                    
        }
        public async Task<IActionResult> OnPostAsync(int id, int quant, string returnUrl)
        {
            GoodDTO good = await goodService.Get(id);
            Cart.AddItem(good, quant);          
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int id, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
            cl.Good.Id== id).Good);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public async Task<IActionResult> OnPostAddOne(int id, string returnUrl)
        {
            GoodDTO good = await goodService.Get(id);
            Cart.AddItem(good, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public async Task<IActionResult> OnPostRemoveOne(int id, string returnUrl)
        {
            GoodDTO good = await goodService.Get(id);
            Cart.AddItem(good, -1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;

namespace WebUI.Pages
{

        public class FavoritesModel : PageModel
        {
            private readonly IGoodService goodService;

            public FavoritesModel(IGoodService goodService, Favorites favService)
            {
                this.goodService = goodService;
                Favorites = favService;
            }

            public Favorites Favorites { get; set; }
            public string ReturnUrl { get; set; }

            public void OnGet(string returnUrl)
            {
                ReturnUrl = returnUrl ?? "/";
            }
            public async Task<IActionResult> OnPostAsync(int id, string returnUrl)
            {
                GoodDTO good = await goodService.Get(id);
                Favorites.AddItem(good);
                return RedirectToPage(new { returnUrl = returnUrl });
            }

            public IActionResult OnPostRemove(int id, string returnUrl)
            {
                Favorites.RemoveLine(Favorites.Lines.First(cl =>
                    cl.Good.Id == id).Good);
                return RedirectToPage(new { returnUrl = returnUrl });
            }

            public async Task<IActionResult> OnPostAddFavorite(int id)
            {
                GoodDTO good = await goodService.Get(id);
                Favorites.AddItem(good);
                return RedirectToAction("Details", "Home", new { id=id});
            }

    }
    }


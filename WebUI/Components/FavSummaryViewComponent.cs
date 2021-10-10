using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Components
{
    public class FavSummaryViewComponent : ViewComponent
    {
        private Favorites favorites;

        public FavSummaryViewComponent(Favorites favorites)
        {
            this.favorites = favorites;
        }

        public IViewComponentResult Invoke()
        {
            return View(favorites);
        }
    }
}

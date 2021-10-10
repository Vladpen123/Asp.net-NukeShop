using BLL.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IGoodService goodService;
        private IManufacturerService manufacturerService;
        private ICategoryService categoryService;

        public HomeController(IGoodService goodService, IManufacturerService manufacturerService, ICategoryService categoryService)
        {
            this.goodService = goodService;
            this.manufacturerService = manufacturerService;
            this.categoryService = categoryService;
        }


        public IActionResult SizeTable() => PartialView("_SizeTable");

        public IActionResult PayInfo() => PartialView("_PayInfo");

        public async Task<IActionResult> Index()
        {
            var goods = (await goodService.GetGoods()).Take(10);
            return View();
        }


        public async Task<IActionResult> Store(
         
             int? category,
             int? manufacturer,
             SortState? sort,
             string name,
             string price,
             int page = 1
            
             )
            
            {


            

           
            int pageSize = 21;

            // Фильтрация списка по категории и произваодителю

 

            var goods = await goodService.GetGoods();

            ViewBag.Max = (int)goods.Max(x => x.Price);
            ViewBag.Min = (int)goods.Min(x => x.Price);

            if (!string.IsNullOrEmpty(price))
            {
                string[] minmax = price.Split(',');
                int min = int.Parse(minmax[0]);
                int max = int.Parse(minmax[1]);

                goods = goods.Where(x => x.Price >= min && x.Price<=max);
            }

            if (manufacturer != null && manufacturer != 0)
                goods = goods.Where(x => x.ManufacturerId == manufacturer).ToList();

            if (category != null && category != 0)
                goods = goods.Where(x => x.CategoryId == category).ToList();
        
            if (!string.IsNullOrEmpty(name))
            {
                goods = goods.Where(p => p.FullName.Contains(name.ToUpper()) || p.FullName.Contains(name)).ToList();
            }

            //сортировка (по дефолту по имени)
            goods = sort switch
            {
                SortState.PriceAsc => goods.OrderBy(s => s.Price),
                SortState.PriceDesc => goods.OrderByDescending(s => s.Price),
                _ => goods.OrderBy(s => s.Name),
            };

            // пагинация 
            var count = goods.Count();
            var items = goods.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            StoreViewModel model = new StoreViewModel
            {
                FilterViewModel = new FilterViewModel((await categoryService.GetCategories()).ToList(), category,
                    (await manufacturerService.GetManufacturers()).ToList(), manufacturer, name),
                SortViewModel = new SortViewModel(sort??SortState.NameAsc),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Goods = items
            };


            return View(model);
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await goodService.Get(id));
        }
    }
}

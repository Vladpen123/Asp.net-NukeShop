using BLL.DTO;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.Controllers
{
    [Authorize(Roles ="admin")]
    [AutoValidateAntiforgeryToken]
    public class AdminController : Controller
    {
        IWebHostEnvironment appEnvironment;
        private readonly IGoodService goodService;
        private readonly ICategoryService categoryService;
        private readonly IManufacturerService manufacturerService;

        public AdminController(IGoodService goodService,
            ICategoryService categoryService,
            IManufacturerService manufacturerService,
            IWebHostEnvironment appEnvironment)
        {
            this.goodService = goodService;
            this.categoryService = categoryService;
            this.manufacturerService = manufacturerService;
            this.appEnvironment = appEnvironment;
        }

        public async Task<IActionResult> Goods(int? category,
            int? manufacturer,           
            SortState? sort,
            int? gender,
            string name,
            string code,
            int page = 1
    
           )
        {

            ViewBag.Cats = new SelectList(await categoryService.GetCategories(), "Id", "Name");
            ViewBag.Mans = new SelectList(await manufacturerService.GetManufacturers(), "Id", "Name");

            int pageSize = 10;

            // Фильтрация списка по категории и произваодителю
            var goods = await goodService.GetGoods();
            if (category != null && category != 0)
                goods = goods.Where(x => x.CategoryId == category);
            if (manufacturer != null && manufacturer != 0)
                goods = goods.Where(x => x.ManufacturerId == manufacturer);
            if (gender != null)
                goods = goods.Where(x => x.Gender == gender.Value);
            if (!string.IsNullOrEmpty(name))
            {
                goods = goods.Where(p => p.Name.Contains(name.ToUpper()) 
                || p.Name.Contains(name)
                || p.CategoryName.Contains(name)
                || p.ManufacturerName.Contains(name)
                || p.Code.Contains(name));
            }
            if (!string.IsNullOrEmpty(code))
            {
                goods = goods.Where(p => p.Code.Contains(code.ToUpper()) || p.Code.Contains(code));
            }

            //сортировка (по дефолту по имени)
            goods = sort switch
            {
                SortState.NameDesc => goods.OrderByDescending(s => s.Name),
                SortState.PriceAsc => goods.OrderBy(s => s.Price),
                SortState.PriceDesc => goods.OrderByDescending(s => s.Price),  
                SortState.CodeAsc => goods.OrderBy(s => s.Code),
                SortState.CodeDesc => goods.OrderByDescending(s => s.Code),
                SortState.GenderAsc => goods.OrderBy(s => s.Gender),
                SortState.GenderDesc => goods.OrderByDescending(s => s.Gender),
                SortState.CategoryAsc => goods.OrderBy(s => s.CategoryName),
                SortState.CategoryDesc => goods.OrderByDescending(s => s.CategoryName),
                SortState.ManufacturerAsc => goods.OrderBy(s => s.ManufacturerName),
                SortState.ManufacturerDesc => goods.OrderByDescending(s => s.ManufacturerName),
                _ => goods.OrderBy(s => s.Name),
            };

            // пагинация 
            var count = goods.Count();
            var items = goods.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            StoreViewModel model = new StoreViewModel
            {
                FilterViewModel = new FilterViewModel((await categoryService.GetCategories()).ToList(), category,
                    (await manufacturerService.GetManufacturers()).ToList(), manufacturer,gender, name,code),
                SortViewModel = new SortViewModel(sort??SortState.NameAsc),
                PageViewModel = new PageViewModel(count, page, pageSize),
                Goods = items
            };


            return View(model);
        }


  

        public async Task<IActionResult> Categories() =>
            View(await categoryService.GetCategories());

        public async Task<IActionResult> Manufacturers() =>
            View(await manufacturerService.GetManufacturers());

        public async Task<IActionResult> DetailsGood(int id)
        {
            if (id != 0)
            {
                var good = await goodService.Get(id);
                if (good != null)
                    return View(good);
                return RedirectToAction("Index", "Admin");
            }
            return RedirectToAction("Index", "Admin");
        }



        public IActionResult CreateGood()
        {
            return PartialView("_CreateGood");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGood(GoodViewModel vm)
        {

            if (!ModelState.IsValid)
            {
                ModelState.Clear();
                return PartialView("_CreateGood", vm);
            }
                

            if (vm.PhotoPath == null)
                return PartialView("_CreateGood", vm);
            string path = "/Files/" + vm.PhotoPath.FileName;

            using (var filestream = new FileStream(appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await vm.PhotoPath.CopyToAsync(filestream);
            }
            var good = new GoodDTO
            {
                CategoryId = vm.CategoryId,
                ManufacturerId = vm.ManufacturerId,
                Code = vm.Code,
                Price = vm.Price,
                Count = vm.Count,
                Desc = vm.Desc,
                Gender = vm.Gender,
                Name = vm.Name,
                PhotoPath = path,
        };
            await goodService.CreateGood(good);

            return RedirectToAction("Goods");


        }

        public async Task<IActionResult> EditGood(int id)
        {
            ViewBag.Cats = new SelectList(await categoryService.GetCategories(), "Id", "Name");
            ViewBag.Mans = new SelectList(await manufacturerService.GetManufacturers(), "Id", "Name");

            if (id != 0)
            {
                var good = await goodService.Get(id);

                var vm = new GoodViewModel
                {
                    CategoryId = good.CategoryId,
                    ManufacturerId = good.ManufacturerId,
                    Code = good.Code,
                    Price = good.Price,
                    Count = good.Count,
                    Desc = good.Desc,
                    Gender = good.Gender,
                    Name = good.Name,
                    Id = good.Id
                    
                };
                return PartialView("_EditGood", vm); 
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditGood(GoodViewModel vm)
        {
            if (!ModelState.IsValid)
                return PartialView("_EditGood", vm);

            ViewBag.Cats = new SelectList(await categoryService.GetCategories(), "Id", "Name");
            ViewBag.Mans = new SelectList(await manufacturerService.GetManufacturers(), "Id", "Name");

      

            if (vm.PhotoPath == null)
                return PartialView("_EditGood",vm);
            string path = "/Files/" + vm.PhotoPath.FileName;

            using (var filestream = new FileStream(appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await vm.PhotoPath.CopyToAsync(filestream);
            }
            var good = new GoodDTO
            {
                Id = vm.Id,
                CategoryId = vm.CategoryId,
                ManufacturerId = vm.ManufacturerId,
                Code = vm.Code,
                Price = vm.Price,
                Count = vm.Count,
                Desc = vm.Desc,
                Gender = vm.Gender,
                Name = vm.Name,
                PhotoPath = path
            };
            await goodService.UpdateGood(good);

            return RedirectToAction("Goods");
        }


        [HttpGet]
        [ActionName("DeleteGood")]
        public async Task<IActionResult> ConfirmDeleteGood(int id)
        {
            if (id != 0)
            {
                var good = await goodService.Get(id);
                if (good != null)
                    return PartialView("_ConfirmDeleteGood",good);

            }
            return NotFound();
        }
      //  [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> DeleteGood(int id)
        {
            if (id != 0)
            {
                var good = await goodService.Get(id);
                if (good != null)
                {
                    await goodService.DeleteGood(id);
                    return RedirectToAction("Goods");
                }
            }
            return NotFound();
        }


        public IActionResult CreateCategory() =>
            PartialView("_CreateCategory",new CategoryViewModel());

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel vm)
        {
            if (!ModelState.IsValid)
                return PartialView("_CreateCategory", vm);

            var category = new CategoryDTO
            {
                Name = vm.Name,
            };
            await categoryService.CreateCategory(category);

            return RedirectToAction("Categories");
        }

        public async Task<IActionResult> EditCategory(int id)
        {      
            if (id != 0)
            {
                var category = await categoryService.Get(id);

                var vm = new CategoryViewModel
                {
                    Name = category.Name,
                    Id = category.Id,
                    Goods = category.Goods
                };

                return PartialView("_EditCategory", vm);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryViewModel vm)
        {
           
            var category = new CategoryDTO
            {
                Id = vm.Id,             
                Name = vm.Name,
                //Goods = vm.Goods
                //Goods =( await categoryService.Get(vm.Id)).Goods
            };
            await categoryService.UpdateCategory(category);

            return RedirectToAction("Categories");
        }

        [HttpGet]
        [ActionName("DeleteCategory")]
        public async Task<IActionResult> ConfirmDeleteCategory(int id)
        {
            if (id != 0)
            {
                var category = await categoryService.Get(id);
                if (category != null)
                    return PartialView("_DeleteCategoryPartial", category);

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (id != 0)
            {
                var category = await categoryService.Get(id);
                if (category != null)
                {
                    await categoryService.DeleteCategory(id);
                    return RedirectToAction("Categories");
                }
            }
            return NotFound();
        }


        public IActionResult CreateManufacturer() =>
          PartialView("_CreateManufacturer", new ManufacturerViewModel());

        [HttpPost]
        public async Task<IActionResult> CreateManufacturer(ManufacturerViewModel vm)
        {
            if (!ModelState.IsValid)
                return PartialView("_CreateManufacturer", vm);

            var manufacturer = new ManufacturerDTO
            {
                Name = vm.Name,
            };
            await manufacturerService.CreateManufacturer(manufacturer);

            return RedirectToAction("Manufacturers");
        }

        [HttpGet]
        [ActionName("DeleteManufacturer")]
        public async Task<IActionResult> ConfirmDeleteManufacturer(int id)
        {
            if (id != 0)
            {
                var manufacturer = await manufacturerService.Get(id);
                if (manufacturer != null)
                    return PartialView("_DeleteManufacturerPartial", manufacturer);

            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            if (id != 0)
            {
                var manufacturer = await manufacturerService.Get(id);
                if (manufacturer != null)
                {
                    await manufacturerService.DeleteManufacturer(id);
                    return RedirectToAction("Manufacturers");
                }
            }
            return NotFound();
        }


    }
}

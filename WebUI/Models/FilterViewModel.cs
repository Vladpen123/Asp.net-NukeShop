using BLL.DTO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(List<CategoryDTO> categories,
            int? category,
            List<ManufacturerDTO> manufacturers,
            int? manufactrer,
            string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            categories.Insert(0, new CategoryDTO { Name = "Все", Id = 0 });
            manufacturers.Insert(0, new ManufacturerDTO { Name = "Все", Id = 0 });
            Categories = new SelectList(categories, "Id", "Name", category);
            Manufacturers = new SelectList(manufacturers, "Id", "Name", manufactrer);
            SelectedCategory = category;
            SelectedManufacturer = category;
            SelectedName = name;
        }
        public FilterViewModel(List<CategoryDTO> categories,
    int? category,
    List<ManufacturerDTO> manufacturers,
    int? manufactrer,
    string name,
    string code)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            categories.Insert(0, new CategoryDTO { Name = "Все", Id = 0 });
            manufacturers.Insert(0, new ManufacturerDTO { Name = "Все", Id = 0 });
            Categories = new SelectList(categories, "Id", "Name", category);
            Manufacturers = new SelectList(manufacturers, "Id", "Name", manufactrer);
            SelectedCategory = category;
            SelectedManufacturer = category;
            SelectedName = name;
            SelectedCode = code;
        }

        public FilterViewModel(List<CategoryDTO> categories,
   int? category,
   List<ManufacturerDTO> manufacturers,
   int? manufactrer,
   int? gender,
   string name,
   string code)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            categories.Insert(0, new CategoryDTO { Name = "Все", Id = 0 });
            manufacturers.Insert(0, new ManufacturerDTO { Name = "Все", Id = 0 });
            Categories = new SelectList(categories, "Id", "Name", category);
            Manufacturers = new SelectList(manufacturers, "Id", "Name", manufactrer);
            SelectedCategory = category;
            SelectedManufacturer = category;
            SelectedGender = gender;
            SelectedName = name;
            SelectedCode = code;
        }

        public SelectList Manufacturers { get; private set; } // список производителей
        public SelectList Categories { get; private set; } // список категорий


        public int? SelectedCategory { get; private set; }   // выбранная категория
        public int? SelectedGender { get; private set; }   // выбранная категория

        public int? SelectedManufacturer { get; private set; }   
        public string SelectedName { get; private set; }    // введенное имя
        public string SelectedCode { get; private set; }    // введенный атикул

    }
}

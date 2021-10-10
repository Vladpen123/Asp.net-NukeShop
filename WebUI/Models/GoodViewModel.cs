using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class GoodViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Введите имя")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        public string Desc { get; set; }
        [Required(ErrorMessage = "Введите артикул товара")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Выберите пол")]
        public int Gender { get; set; }
        [Required(ErrorMessage ="Выберите фото товара")]
        public IFormFile PhotoPath { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Выберите пол")]
        public int Count { get; set; }
        [Required(ErrorMessage = "Выберите категорию товара")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Выберите производителя товара")]
        public int ManufacturerId { get; set; }
    }
}

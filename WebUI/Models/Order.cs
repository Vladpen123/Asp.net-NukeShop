using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        [BindNever]
        public IEnumerable<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Введите вашу фамилию")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Введите ваше имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Введите ваше отчество")]
        public string Patronim { get; set; }
        [Required(ErrorMessage = "Введите ваш адрес")]
        public string Address { get; set; }
    }
}

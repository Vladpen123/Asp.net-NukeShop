using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class GoodDTO
    {
        public GoodDTO()
        {
            
        }

        //private void ParseGender()
        //{
        //    switch (Gender)
        //    {
        //        case "Male":
        //            Gender = "Для мужчин";
        //            break;
        //        case "Female":
        //            Gender = "Для женщин";
        //            break;
        //        case "Kids":
        //            Gender = "Для детей";
        //            break;
        //        default:
        //            break;
        //    }
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string Code { get; set; }
        public int Gender { get; set; }
        public string PhotoPath { get; set; }
        public int Count { get; set; }
        public string FullName { get; set; }


        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
    }
}

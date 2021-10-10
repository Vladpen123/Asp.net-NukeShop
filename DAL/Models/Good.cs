using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{


    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Desc { get; set; }
        public string Code { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }
        public int Count { get; set; }

        // TO DO
        //public string Color { get; set; }
        //public string ShortDesc { get; set;}
        //public IEnumerable<Size> Sizes{get;set;}

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}

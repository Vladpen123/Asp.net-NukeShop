using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class ShopContext : DbContext

    {
        public ShopContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name="Кроссовки"},
                 new Category { Id = 2, Name = "Футболки" },
                  new Category { Id = 3, Name = "Шорты" },
                   new Category { Id = 4, Name = "Аксессуары" }
                );
            modelBuilder.Entity<Manufacturer>().HasData(
             new Manufacturer { Id = 1, Name = "Nike" },
              new Manufacturer { Id = 2, Name = "Adidas" },
               new Manufacturer { Id = 3, Name = "Puma" },
                new Manufacturer { Id = 4, Name = "Helly Henson" }
             );
            modelBuilder.Entity<Good>().HasData(
                new Good
                {
                    Id = 1,
                    Name = "REACT VAPOR NXT CLY",
                    CategoryId = 1,
                    Code = "CV0726-007",
                    Count = 23,
                    Desc = "КРОССОВКИ NIKE M REACT VAPOR NXT CLY АРТИКУЛ: CV0726-007",
                    Gender = Gender.Male,
                    ManufacturerId = 1,
                    Price = 7379.00m,
                    PhotoPath = "/Files/CV0726_007_preview.png"
                }
        );
        }
    }

    


}

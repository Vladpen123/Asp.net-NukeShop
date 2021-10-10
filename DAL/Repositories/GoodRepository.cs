using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GoodRepository : GenericRepository<Good>, IGoodRepository
    {
        public GoodRepository(ShopContext context) : base(context)
        {
        }

        public override async Task<Good> Add(Good good)
        {
            var result = await set.AddAsync(good);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public override async Task Delete(int id)
        {
            var result = await set.FirstOrDefaultAsync(x => x.Id == id);
            if (result != null)
            {
                set.Remove(result);
                await context.SaveChangesAsync();
            }
        }

        public override async Task<Good> Get(int id)
        {
            return await set
                .Include(x => x.Category)
                .Include(x => x.Manufacturer)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<IEnumerable<Good>> GetAll()
        {
            return await set
                .Include(x => x.Category)
                .Include(x => x.Manufacturer)
                .ToListAsync();
        }

        public override async Task<Good> Update(Good good)
        {
            //set.Attach(good);
            //context.Entry(good).State = EntityState.Modified;
            //return good;

            var result = await set.FirstOrDefaultAsync(x => x.Id == good.Id);
            if (result != null)
            {
                //result.Id = good.Id;
                result.Name = good.Name;
                result.Price = good.Price;
                result.Count = good.Count;
                result.Code = good.Code;
                result.Gender = good.Gender;
                result.PhotoPath = good.PhotoPath;
                result.Desc = good.Desc;

                result.CategoryId = good.CategoryId;
                result.ManufacturerId = good.ManufacturerId;


                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}

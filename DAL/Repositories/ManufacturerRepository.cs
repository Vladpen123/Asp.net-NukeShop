using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(ShopContext context) : base(context)
        {
        }

        public override async Task<Manufacturer> Add(Manufacturer manufacturer)
        {
            var result = await set.AddAsync(manufacturer);
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

        public override async Task<Manufacturer> Get(int id)
        {
            return await set
                .Include(x => x.Goods)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<IEnumerable<Manufacturer>> GetAll()
        {
            return await set
                .Include(x => x.Goods)
                .ToListAsync();
        }

        public override async Task<Manufacturer> Update(Manufacturer manufacturer)
        {
            var result = await set.FirstOrDefaultAsync(x => x.Id == manufacturer.Id);
            if (result != null)
            {
                result.Id = manufacturer.Id;
                result.Name = manufacturer.Name;
                result.Goods = manufacturer.Goods;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }


    }
}

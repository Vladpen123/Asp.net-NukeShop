using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ShopContext context) : base(context)
        {
        }

        public override async Task<Category> Add(Category category)
        {
            var result = await set.AddAsync(category);
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

        public override async Task<Category> Get(int id)
        {
            return await set.Include(x => x.Goods).FirstOrDefaultAsync(x => x.Id == id);
        }

        public override async Task<IEnumerable<Category>> GetAll()
        {
            return await set
                .Include(x => x.Goods)
                .ToListAsync();
        }

        public override async Task<Category> Update(Category category)
        {
            var result = await set.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (result != null)
            {
                result.Id = category.Id;
                result.Name = category.Name;
                result.Goods = category.Goods;

                await context.SaveChangesAsync();

                return result;
            }
            return null;
        }

       
    }
}

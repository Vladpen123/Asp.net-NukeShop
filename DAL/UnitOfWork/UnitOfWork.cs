using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ShopContext context;

        public UnitOfWork(ShopContext context, IGoodRepository goods, IManufacturerRepository manufacturers, ICategoryRepository categories)
        {
            this.context = context;
            Goods = new GoodRepository(context);
            Manufacturers = new ManufacturerRepository(context);
            Categories = new CategoryRepository(context);
        }

        public IGoodRepository Goods { get; private set; }

        public IManufacturerRepository Manufacturers { get; private set; }

        public ICategoryRepository Categories { get; private set; }



        public void Dispose()
        {
            context.Dispose();
        }
    }
}

using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGoodRepository Goods { get; }
        IManufacturerRepository Manufacturers { get; }
        ICategoryRepository Categories { get; }

    }
}

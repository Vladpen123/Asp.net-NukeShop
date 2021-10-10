using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public enum SortState
    {
        NameAsc,   // по имени по убыванию
        PriceAsc, // по цене по возрастанию
        PriceDesc,    // по цене по убыванию
        NameDesc,
        CodeAsc,
        CodeDesc,
        GenderAsc,
        GenderDesc,
        CategoryAsc,
        CategoryDesc,
        ManufacturerAsc,
        ManufacturerDesc,
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class SortViewModel
    {
        public SortState NameAsc { get; private set; } = SortState.NameAsc;
        public SortState NameDesc { get; private set; } = SortState.NameDesc;
        public SortState PriceAsc  { get; private set; } = SortState.PriceAsc;
        public SortState PriceDesc { get; private set; } = SortState.PriceDesc;
        public SortState Current { get; private set; }
        public SortState NameSort { get; private set; } 
        public SortState PriceSort { get; private set; } 
        public SortState CodeSort { get; private set; }
        public SortState GenderSort { get; private set; }
        public SortState CategorySort { get; private set; }
        public SortState ManufacturerSort { get; private set; }

        public SortViewModel(SortState sortOrder)
        {
            NameSort = sortOrder == SortState.NameAsc ? SortState.NameDesc : SortState.NameAsc;
            PriceSort = sortOrder == SortState.PriceAsc ? SortState.PriceDesc : SortState.PriceAsc;
            CodeSort = sortOrder == SortState.CodeAsc ? SortState.CodeDesc: SortState.CodeAsc;
            GenderSort = sortOrder == SortState.GenderAsc ? SortState.GenderDesc : SortState.GenderAsc;
            CategorySort = sortOrder == SortState.CategoryAsc ? SortState.CategoryDesc : SortState.CategoryAsc;
            ManufacturerSort = sortOrder == SortState.ManufacturerAsc ? SortState.ManufacturerDesc : SortState.ManufacturerDesc;


            Current = sortOrder;
        }
    }
}

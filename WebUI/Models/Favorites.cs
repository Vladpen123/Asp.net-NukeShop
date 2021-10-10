using BLL.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Favorites
    {
        public List<FavLine> Lines { get; set; } = new List<FavLine>();
        public virtual void AddItem(GoodDTO good)
        {
             FavLine line = Lines
            .Where(p => p.Good.Id == good.Id)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new FavLine
                {
                    Good = good
                });
            }
        }
        public virtual void RemoveLine(GoodDTO good) =>
            Lines.RemoveAll(l => l.Good.Id == good.Id);
        public virtual void Clear()
            => Lines.Clear();
    }
    public class FavLine
    {
        public int CartLineId { get; set; }
        public GoodDTO Good { get; set; }
    }
}


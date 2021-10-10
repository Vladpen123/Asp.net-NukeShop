using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(GoodDTO good, int quantity)
        {
            CartLine line = Lines
            .Where(p => p.Good.Id == good.Id)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Good = good,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(GoodDTO good) =>
            Lines.RemoveAll(l => l.Good.Id== good.Id);
        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Good.Price * e.Quantity);
        public virtual void Clear() 
            => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public GoodDTO Good { get; set; }
        public int Quantity { get; set; }
    }
}

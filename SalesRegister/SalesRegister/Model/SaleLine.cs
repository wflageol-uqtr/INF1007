using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRegister.Model
{
    public class SaleLine
    {
        public Item Item { get; }
        public int Quantity { get; set; }
        public decimal SubTotal { get { return Item.Price * Quantity; } }
        // public decimal SubTotal => Item.Price * Quantity;

        public SaleLine(Item item)
        {
            Item = item;
            Quantity = 1;
        }
    }
}

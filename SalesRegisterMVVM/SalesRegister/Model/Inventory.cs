using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRegister.Model
{
    public sealed class Inventory
    {
        public static Inventory Singleton { get; } = new Inventory();

        private Inventory() { }

        private IEnumerable<Item> items { get; } = new Item[]
        {
            new Item("35b7d0f3-58c2-448e-8487-2791cf7ea6a5", "Chaussures de course", 119.99M),
            new Item("22dc5291-607c-4606-9bc1-40bae3f63091", "Casque de vélo", 19.95M),
            new Item("d2344396-8f46-4f3a-bb1e-dec50d52dc1c", "Gants de boxe", 69.99M)
        };

        public Item? SearchItem(string id)
        {
            foreach(var item in items)
            {
                if (string.Equals(item.Id, id))
                    return item;
            }

            return null;
        }
    }
}

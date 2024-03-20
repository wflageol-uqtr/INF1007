using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRegister.Model
{
    public class Item
    {
        private Guid id;
        public string Id { get { return id.ToString(); } }
        public string Name { get; }
        public decimal Price { get; }

        public Item(string id, string name, decimal price)
        {
            this.id = Guid.Parse(id);
            Name = name;
            Price = price;
        }
    }
}

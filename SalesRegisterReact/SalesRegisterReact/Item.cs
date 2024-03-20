using System;

namespace ReactPlayground
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRegister.Model
{
    public class Sale
    {
        private List<SaleLine> saleLines = new();

        public IEnumerable<SaleLine> SaleLines
        {
            get { return saleLines; }
        }

        public SaleLine AddLine(Item item)
        {
            var line = SearchLine(item);

            if (line == null)
            {
                line = new SaleLine(item);
                saleLines.Add(line);
            } else
            {
                line.Quantity += 1;
            }

            return line;
        }

        private SaleLine? SearchLine(Item item)
        {
            return saleLines.Find(line => line.Item == item);
        }

        public decimal CalculateTotal()
        {
            return saleLines.Sum(line => line.SubTotal);
        }
    }
}

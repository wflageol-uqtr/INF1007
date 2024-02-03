using SalesRegister.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesRegister.ViewModel
{
    public class SaleLineViewModel : BaseViewModel
    {
        private SaleLine saleLine;

        public string Name => saleLine.Item.Name;
        public decimal Price => saleLine.Item.Price;
        public int Quantity => saleLine.Quantity;

        public SaleLineViewModel(SaleLine saleLine)
        {
            this.saleLine = saleLine;
        }
    }
}

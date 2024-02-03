using SalesRegister.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace SalesRegister.ViewModel
{
    public class SaleViewModel : BaseViewModel
    {
        private Sale sale = new();

        private Random random = new Random();

        public ObservableCollection<SaleLineViewModel> SaleLines { get; } = new();
        public string Total => string.Format("{0:C2}", sale.CalculateTotal());

        public void ScanItem()
        {
            // Ici, on choisi au hasard parmis un des trois ID.
            // Dans un vrai système, l'ID scanné serait fourni par un système externe.
            var scannedID = new string[] 
            { 
                "35b7d0f3-58c2-448e-8487-2791cf7ea6a5", 
                "22dc5291-607c-4606-9bc1-40bae3f63091", 
                "d2344396-8f46-4f3a-bb1e-dec50d52dc1c" 
            }[random.Next(3)];

            var item = Inventory.Singleton.SearchItem(scannedID);

            if (item != null)
                AddSaleLine(item);
        }

        private void AddSaleLine(Item item)
        {
            sale.AddLine(item);

            RebuildSaleLines();
            RaisePropertyChanged("Total");
        }

        private void RebuildSaleLines()
        {
            SaleLines.Clear();
            foreach (var line in sale.SaleLines)
                SaleLines.Add(new SaleLineViewModel(line));
        }
    }
}

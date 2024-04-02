using AgenceLocationModel.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AgenceLocation
{
    /// <summary>
    /// Logique d'interaction pour VehicleList.xaml
    /// </summary>
    public partial class VehicleList : Page
    {
        public VehicleList(IEnumerable<Vehicle> vehicles)
        {
            InitializeComponent();

            ListView.ItemsSource = vehicles;
        }
    }
}

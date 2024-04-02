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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VehicleListController vehicleListController;

        public MainWindow()
        {
            var agency = new RentalAgency();
            vehicleListController = new(agency);

            InitializeComponent();
        }

        private void VehicleListButton_Click(object sender, RoutedEventArgs e)
        {
            var selector = new DateRangeSelector(
                (start, end) => NavigateFrame.Navigate(vehicleListController.CreatePage(start, end)),
                () => NavigateFrame.Navigate(null));

            NavigateFrame.Navigate(selector);
        }
    }
}

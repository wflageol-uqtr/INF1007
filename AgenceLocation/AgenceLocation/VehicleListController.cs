using AgenceLocationModel.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AgenceLocation
{
    class VehicleListController
    {
        private RentalAgency rentalAgency;

        public VehicleListController(RentalAgency rentalAgency)
        {
            this.rentalAgency = rentalAgency;
        }

        public Page CreatePage(DateTime start, DateTime end)
        {
            return new VehicleList(rentalAgency.ListAvailableVehicles(start, end));
        }
    }
}

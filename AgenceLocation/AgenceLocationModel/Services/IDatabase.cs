using AgenceLocationModel.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.Services
{
    public interface IDatabase
    {
        IEnumerable<Vehicle> QueryVehicles();
        IEnumerable<Rental> QueryRentals();
        IEnumerable<Reservation> QueryReservations();
    }
}

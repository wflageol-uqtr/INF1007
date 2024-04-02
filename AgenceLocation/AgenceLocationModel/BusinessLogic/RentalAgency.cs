using AgenceLocationModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.BusinessLogic
{
    public class RentalAgency
    {
        private IDatabase database;

        public RentalAgency()
        {
            database = Database.Instance;
        }

        public RentalAgency(IDatabase database)
        {
            this.database = database;
        }

        public IEnumerable<Vehicle> ListAvailableVehicles(DateTime begin, DateTime end)
        {
            var available = new List<Vehicle>(database.QueryVehicles());

            // Retrait des véhicules avec location pour la période de temps.
            foreach(var rental in database.QueryRentals())
            {
                if (rental.IsActive(begin, end))
                    available.Remove(rental.RentedVehicle);
            }

            // Retrait des véhicules avec réservation pour la période de temps.
            foreach(var reservation in database.QueryReservations())
            {
                if (reservation.IsActive(begin, end))
                    available.Remove(reservation.ReservedVehicle);
            }

            // Retrait des véhicules en réparation.
            // Ici j'utilise ToArray pour faire une copie de la liste pour
            // pouvoir la modifier durant le foreach sur elle-même.
            foreach(var vehicle in available.ToArray())
            {
                if (vehicle.Repair != null)
                    available.Remove(vehicle);
            }

            return available;
        }
    }
}

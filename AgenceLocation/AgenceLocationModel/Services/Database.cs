using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenceLocationModel.BusinessLogic;

namespace AgenceLocationModel.Services
{
    internal class Database : IDatabase
    {
        public static Database Instance { get; } = new();

        private Vehicle toyota = new Vehicle(new VehicleType("Resources/toyota-corolla-2021.jpg", "Toyota", "Corolla 2021"));
        private Vehicle ford = new Vehicle(new VehicleType("Resources/ford-focus-2019.jpg", "Ford", "Focus 2019"));
        private Vehicle hyundai = new Vehicle(new VehicleType("Resources/hyundai-santa-fe-2012.jpg", "Hyundai", "Santa Fe 2012"));

        // Database est un Singleton; une seule instance ne peut exister dans le programme.
        private Database() 
        {
            toyota.State = "Quelques égratignures sur la porte du conducteur.";
        }

        public IEnumerable<Vehicle> QueryVehicles()
        {
            return new Vehicle[] { toyota, ford, hyundai };
        }

        public IEnumerable<Rental> QueryRentals()
        {
            return new Rental[] 
            { 
                new Rental(new DateTime(2024, 05, 01), new DateTime(2024, 05, 03), toyota),
                new Rental(new DateTime(2024, 05, 11), new DateTime(2024, 05, 17), hyundai),
            };
        }

        public IEnumerable<Reservation> QueryReservations()
        {
            return new Reservation[]
            {
                new Reservation(new DateTime(2024, 05, 03), new DateTime(2024, 05, 20), ford)
            };
        }
    }
}

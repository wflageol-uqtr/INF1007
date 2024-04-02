using AgenceLocationModel.Utils;
using System;

namespace AgenceLocationModel.BusinessLogic
{
    public class Rental
    {
        private DateTime begin;
        private DateTime end;
        public Vehicle RentedVehicle { get; }

        public Rental(DateTime begin, DateTime end, Vehicle rentedVehicle)
        {
            this.begin = begin;
            this.end = end;
            RentedVehicle = rentedVehicle;
        }

        public bool IsActive(DateTime begin, DateTime end)
            => DateTimeUtils.Overlap(begin, end, this.begin, this.end);
    }
}

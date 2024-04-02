using AgenceLocationModel.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.BusinessLogic
{
    public class Reservation
    {
        private DateTime begin;
        private DateTime end;
        public Vehicle ReservedVehicle { get; }

        public Reservation(DateTime begin, DateTime end, Vehicle reservedVehicle)
        {
            this.begin = begin;
            this.end = end;
            ReservedVehicle = reservedVehicle;
        }

        public bool IsActive(DateTime begin, DateTime end) 
            => DateTimeUtils.Overlap(begin, end, this.begin, this.end);

    }
}

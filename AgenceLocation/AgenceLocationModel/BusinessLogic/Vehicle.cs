using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.BusinessLogic
{
    public class Vehicle
    {
        public Repair Repair { get; set; }

        public string State { get; set;  } = "";
        public VehicleType Type { get; }

        public Vehicle(VehicleType type)
        {
            Type = type;
        }
    }
}

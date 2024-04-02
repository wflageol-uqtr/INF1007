using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceLocationModel.BusinessLogic
{
    public class VehicleType
    {
        public string Image { get; }
        public string Brand { get; }
        public string Model { get; }

        public VehicleType(string image, string brand, string model)
        {
            Image = image;
            Brand = brand;
            Model = model;
        }
    }
}

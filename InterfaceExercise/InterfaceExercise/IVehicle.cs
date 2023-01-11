using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfDoors { get; set; }
        public int CargoSpaceSqFt { get; set; }

        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
    
        public string CountryOfManufacturing { get; set; }

        public int SeatingCapacity { get; set; }
        public void IsDriving()
        {
            Console.WriteLine($"You better act fast if you want one, the {VehicleMake} {VehicleModel} is driving down the road.....");
        }
    }
}

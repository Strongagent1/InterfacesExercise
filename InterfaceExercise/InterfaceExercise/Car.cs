using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        
        public int CargoSpaceSqFt { get; set; }
        public bool HasTrunk { get; set; }
        public int NumberOfDoors { get; set; }
        public string VehicleMake { get ; set; }
        public string VehicleModel { get; set; }
        public int SeatingCapacity { get; set; }
        public string Logo { get; set; }
        public string CountryOfManufacturing { get; set; }
    }
}

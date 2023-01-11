using InterfaceExercise;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

var car1 = new Car()
{
    CargoSpaceSqFt = 20,
    CountryOfManufacturing = "USA",
    HasTrunk = true,
    VehicleMake = "Chevrolet",
    VehicleModel = "Impala",
    NumberOfDoors = 4,
    SeatingCapacity = 4,
    Logo = "Bowtie"
};

var car2 = new Car()
{
    VehicleMake = "Hyundai",
    VehicleModel = "Sonata",
    SeatingCapacity = 5,
    NumberOfDoors = 4,
    HasTrunk = true,
    CargoSpaceSqFt = 24,
    CountryOfManufacturing = "Korea",
    Logo = "H"
};

var truck1 = new Truck()
{
    VehicleMake = "Ford",
    VehicleModel = "F-150",
    NumberOfDoors = 2,
    WheelDrive = 4,
    Logo = "FORD",
    CountryOfManufacturing = "USA",
    SeatingCapacity = 2,
    HasTruckBed = true,
    CargoSpaceSqFt = 48,
};

var truck2 = new Truck()
{
    VehicleMake = "Chevrolet",
    VehicleModel = "Silverado",
    NumberOfDoors = 3,
    WheelDrive = 4,
    Logo = "Bowtie",
    CountryOfManufacturing = "USA",
    SeatingCapacity = 4,
    HasTruckBed = true,
    CargoSpaceSqFt = 54,
    
};
var suv1 = new SUV()
{
    VehicleMake = "GMC",
    VehicleModel = "YukonXL",
    NumberOfDoors = 4,
    WheelDrive = 4,
    Logo = "GMC",
    CountryOfManufacturing = "USA",
    SeatingCapacity = 8,
    CargoSpaceSqFt = 45,

};

var suv2 = new SUV()
{
    VehicleMake = "BMW",
    VehicleModel = "X5",
    NumberOfDoors = 4,
    WheelDrive = 2,
    Logo = "BMW",
    CountryOfManufacturing = "Germany",
    SeatingCapacity = 5,
    CargoSpaceSqFt = 25,

};

var vehicleList = new List<IVehicle>();
//var vehicleList1 = new List<IVehicle>();
//var vehicleList2 = new List<ICompany>();
//var vehicleList = vehicleList1.Add((ICompany)vehicleList2)();


//vehicleList2.Add(car1);
//vehicleList2.Add(car2);
//vehicleList2.Add(truck1);
//vehicleList2.Add(truck2);
//vehicleList2.Add(suv1);
//vehicleList2.Add(suv2);
vehicleList.Add(car1);
vehicleList.Add(car2);
vehicleList.Add(truck1);
vehicleList.Add(truck2);
vehicleList.Add(suv1);
vehicleList.Add(suv2);


foreach (var vehicle in vehicleList)
{
    
    Console.WriteLine($"The {vehicle.VehicleMake} {vehicle.VehicleModel} has {vehicle.NumberOfDoors} doors and seating capacity " +
        $"for {vehicle.SeatingCapacity}. The {vehicle.VehicleModel} has approximately {vehicle.CargoSpaceSqFt} sq ft. of cargo space" +
        $" to store all of your gear. This vehicle is manufactured in {vehicle.CountryOfManufacturing} but you can own one anywhere!");
    vehicle.IsDriving();
    Console.WriteLine("-----------------");
    

}

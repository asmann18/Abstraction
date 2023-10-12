using Abstraction.Models;

namespace Encapsulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles=new Vehicle[0];
            Car Car1=new Car("LADA","06","Black",20,200000,4,false);
            Car Car2=new Car("LADA","07","White",16,150000,4,false);
            Bicycle bicycle = new("empty", "empty", "orange", 4, 40, 10);
            AddVehicle(ref vehicles, Car1);
            AddVehicle(ref vehicles, Car2);
            AddVehicle(ref vehicles, bicycle);
            PrintArray(vehicles);
        }
        public static void AddVehicle(ref Vehicle[] vehicles,Vehicle vehicle)
        {
            Array.Resize(ref vehicles, vehicles.Length+1);
            vehicles[vehicles.Length-1]= vehicle;
        }
        public static void PrintArray(Vehicle[] vehicles)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
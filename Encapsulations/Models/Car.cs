namespace Abstraction.Models;

public class Car : Vehicle
{
    public Car(string factoryName, string model, string color, decimal driveTime, decimal drivePath,byte dourCount,bool isElectric) : base(factoryName, model, color, driveTime, drivePath)
    {
        DourCount = dourCount;
        IsElctricCar= isElectric;
    }
    public byte DourCount { get; set; }
    public bool IsElctricCar { get; set; }
    public override void DefineNatureHarmness()
    {
        if (IsElctricCar)
        {
            Console.WriteLine("Low");
            return;
        }
        Console.WriteLine("High");
    }
    public override void GetInfo()
    {
        Console.WriteLine($"{FactoryName}-{Model}-{Color}\n Drive Path:{DrivePath} DriveTime:{DriveTime} Year:{ProductionDate} DoorCount:{DourCount} IsElectric:{IsElctricCar}");
    }
}

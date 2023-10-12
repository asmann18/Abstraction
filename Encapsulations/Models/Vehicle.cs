namespace Abstraction.Models;

public abstract class Vehicle
{
    public string FactoryName { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal DriveTime { get; set; }
    public decimal DrivePath { get; set; }
    public DateTime ProductionDate { get; }
    public Vehicle(string factoryName,string model,string color,decimal driveTime,decimal drivePath)
    {
        FactoryName= factoryName;
        Model= model;
        Color= color;
        DriveTime= driveTime;
        DrivePath= drivePath;

    }
    public decimal AverageSpeed()
    {
        return DrivePath / DriveTime;
    }
    public virtual void GetInfo()
    {
        Console.WriteLine($"{FactoryName}-{Model}-{Color}\n Drive Path:{DrivePath} DriveTime:{DriveTime} Year:{ProductionDate} ");

    }
    public abstract void DefineNatureHarmness();
    public override string ToString()
    {
        return $"{FactoryName}-{Model}";
    }
}

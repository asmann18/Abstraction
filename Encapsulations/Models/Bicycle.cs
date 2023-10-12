namespace Abstraction.Models;

public class Bicycle : Vehicle
{
    public byte SkorusSayi { get; set; } //ingilisce bilmirem kanjdasasd
    public Bicycle(string factoryName, string model, string color, decimal driveTime, decimal drivePath, byte skorusSayi) : base(factoryName, model, color, driveTime, drivePath)
    {

        SkorusSayi = skorusSayi;

    }
    public override void DefineNatureHarmness()
    {
        Console.WriteLine("None");
    }
    public override void GetInfo()
    {
        Console.WriteLine($"{FactoryName}-{Model}-{Color}\n Drive Path:{DrivePath} DriveTime:{DriveTime} Year:{ProductionDate} Skorus sayi:{SkorusSayi}");
    }
}

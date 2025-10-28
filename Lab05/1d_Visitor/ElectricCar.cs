using System;

namespace Lab05._1d_Visitor;

public class ElectricCar : Car
{
    public override void Accept(CarVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void CheckBatteryHealth()
    {
        Console.WriteLine("Checking the battery health");
    }
}

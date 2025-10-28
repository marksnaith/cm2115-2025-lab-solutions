using System;

namespace Lab05._1d_Visitor;

public class PetrolCar : Car
{
    public override void Accept(CarVisitor visitor)
    {
        visitor.Visit(this);
    }

    public void CheckSparkPlugs()
    {
        Console.WriteLine("Checking the spark plugs");
    }
}

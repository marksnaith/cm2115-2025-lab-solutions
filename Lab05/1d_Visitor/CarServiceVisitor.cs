using System;

namespace Lab05._1d_Visitor;

public class CarServiceVisitor : CarVisitor
{
    public void Visit(PetrolCar car)
    {
        car.Start();
        car.CheckSparkPlugs();
    }

    public void Visit(ElectricCar car)
    {
        car.Start();
        car.CheckBatteryHealth();
    }
}

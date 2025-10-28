using System;

namespace Lab05._1d_Visitor;

public interface CarVisitor
{
    void Visit(PetrolCar car);
    void Visit(ElectricCar car);
}

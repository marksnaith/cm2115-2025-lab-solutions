using System;

namespace Lab04._3_AbstractFactory._1_furniture;

public class ModernFurnitureFactory : FurnitureFactory
{
    public IChair Createchair()
    {
        return new ModernChair();
    }

    public ILamp CreateLamp()
    {
        return new ModernLamp();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}

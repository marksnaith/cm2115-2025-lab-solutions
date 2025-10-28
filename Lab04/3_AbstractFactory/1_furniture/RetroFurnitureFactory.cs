using System;

namespace Lab04._3_AbstractFactory._1_furniture;

public class RetroFurnitureFactory : FurnitureFactory
{
    public IChair Createchair()
    {
        return new RetroChair();
    }

    public ILamp CreateLamp()
    {
        return new RetroLamp();
    }

    public ITable CreateTable()
    {
        return new RetroTable();
    }
}

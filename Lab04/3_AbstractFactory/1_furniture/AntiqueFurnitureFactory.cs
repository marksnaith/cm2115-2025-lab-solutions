using System;

namespace Lab04._3_AbstractFactory._1_furniture;

public class AntiqueFurnitureFactory : FurnitureFactory
{
    public IChair Createchair()
    {
        return new AntiqueChair();
    }

    public ILamp CreateLamp()
    {
        return new AntiqueLamp();
    }

    public ITable CreateTable()
    {
        return new AntiqueTable();
    }
}

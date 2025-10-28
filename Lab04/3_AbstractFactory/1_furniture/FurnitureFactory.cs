using System;

namespace Lab04._3_AbstractFactory;

public interface FurnitureFactory
{
    IChair Createchair();
    ITable CreateTable();
    ILamp CreateLamp();
}

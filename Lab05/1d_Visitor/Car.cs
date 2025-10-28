using System;

namespace Lab05._1d_Visitor;

public abstract class Car
{
    public abstract void Accept(CarVisitor visitor);

    public void Start()
    {
        Console.WriteLine("The car is started");
    }
}

using System;

namespace Lab05._1a_Command;

public class Box : Pickable
{
    public void Drop()
    {
        Console.WriteLine("Dropping the box");
    }

    public void PickUp()
    {
        Console.WriteLine("Picking up the box");
    }
}

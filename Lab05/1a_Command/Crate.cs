using System;

namespace Lab05._1a_Command;

public class Crate : Pickable
{
    public void Drop()
    {
        Console.WriteLine("Dropping the crate");
    }

    public void PickUp()
    {
        Console.WriteLine("Picking up the crate");
    }
}
